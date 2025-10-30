using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsFormOI
{
    public class PipeServer : IDisposable
    {

        private readonly string _pipeName;
        private NamedPipeServerStream _server;

        public PipeServer(string pipeName)
        {
            _pipeName = pipeName;
        }

        public async Task<byte[]> SendAndReceivePDFAsync(byte[] pdfBytes)
        {
            Console.WriteLine("Aguardando conexão do Python...");

            _server = new NamedPipeServerStream(
                _pipeName,
                PipeDirection.InOut,
                1,
                PipeTransmissionMode.Byte,
                PipeOptions.Asynchronous
            );

            await _server.WaitForConnectionAsync();
            Console.WriteLine("Python conectado!");

            // Envia tamanho + bytes do PDF
            byte[] sizeBytes = BitConverter.GetBytes(pdfBytes.Length);
            await _server.WriteAsync(sizeBytes, 0, sizeBytes.Length);
            await _server.WriteAsync(pdfBytes, 0, pdfBytes.Length);
            await _server.FlushAsync();
            Console.WriteLine($"Enviado PDF ({pdfBytes.Length} bytes).");

            // Recebe o novo PDF
            byte[] sizeBuffer = new byte[4];
            int read = await _server.ReadAsync(sizeBuffer, 0, 4);
            int novoTamanho = BitConverter.ToInt32(sizeBuffer, 0);

            byte[] novoPDF = new byte[novoTamanho];
            int totalLido = 0;
            while (totalLido < novoTamanho)
            {
                int lido = await _server.ReadAsync(novoPDF, totalLido, novoTamanho - totalLido);
                if (lido == 0) break;
                totalLido += lido;
            }

            Console.WriteLine($"Novo PDF recebido ({novoPDF.Length} bytes).");

            return novoPDF;
        }

        public void Dispose()
        {
            _server?.Dispose();
        }
    }
}
