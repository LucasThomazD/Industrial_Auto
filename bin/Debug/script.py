import struct
import io
import fitz  # PyMuPDF
import win32file

PIPE_NAME = r'\\.\pipe\PDFPipe2'

print("Conectando ao servidor C#...")
handle = win32file.CreateFile(
        PIPE_NAME,
        win32file.GENERIC_READ | win32file.GENERIC_WRITE,
        0, None, win32file.OPEN_EXISTING, 0, None
)
print("Conectado!")

# 1️⃣ Ler tamanho + PDF
size_data = win32file.ReadFile(handle, 4)[1]
pdf_size = struct.unpack('<I', size_data)[0]
pdf_bytes = win32file.ReadFile(handle, pdf_size)[1]
print(f"Recebido PDF de {pdf_size} bytes")

# 2️⃣ Modificar PDF
pdf_doc = fitz.open(stream=pdf_bytes, filetype="pdf")

for page in pdf_doc:
        page.insert_text((50, 50), "PDF modificado via Python!", fontsize=18, color=(1, 0, 0))

        novo_pdf_bytes = io.BytesIO()
        pdf_doc.save(novo_pdf_bytes)
        pdf_doc.close()

        novo_bytes = novo_pdf_bytes.getvalue()

        # 3️⃣ Enviar tamanho + bytes do novo PDF
        size_bytes = struct.pack('<I', len(novo_bytes))
        win32file.WriteFile(handle, size_bytes)
        win32file.WriteFile(handle, novo_bytes)

        print(f"Enviado PDF modificado ({len(novo_bytes)} bytes).")

