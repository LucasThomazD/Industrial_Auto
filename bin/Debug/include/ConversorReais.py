from num2words import num2words
import keyboard, pyperclip, signal, os


def corrigir_padrao_brasileiro(texto):
    substituicoes = {
        "dezanove": "dezenove",
        "dezasseis": "dezesseis",
        "dezassete": "dezessete",
    }
    for europeu, brasileiro in substituicoes.items():
        texto = texto.replace(europeu, brasileiro)
    return texto


def encerrar_aplicacao():
    os.kill(os.getpid(), signal.SIGTERM)

def converter_e_copiar(valor_original):
    try:
        valor = float(valor_original.replace(",", "."))
        reais = int(valor)
        centavos = int(round((valor - reais) * 100))

        reais_extenso = num2words(reais, lang='pt') + (" real" if reais == 1 else " reais")
        if centavos > 0:
            centavos_extenso = num2words(centavos, lang='pt') + (" centavo" if centavos == 1 else " centavos")
            resultado = f"{reais_extenso} e {centavos_extenso}"
        else:
            resultado = reais_extenso

        resultado = corrigir_padrao_brasileiro(resultado)
        pyperclip.copy(resultado)
        print(f"Convertido e copiado: {resultado}")

    except ValueError:
        print("[!] Valor inválido na área de transferência.")

def atalho_acionado():
    try:
        valor_colado = pyperclip.paste().strip()
        converter_e_copiar(valor_colado)
    except:
        print("[!] Erro ao acessar a área de transferência.")

keyboard.add_hotkey("ctrl+\\", atalho_acionado)
keyboard.add_hotkey("ctrl+q", encerrar_aplicacao())



print(" Conversor rodando em segundo plano. Use Ctrl+\\ para converter.")
keyboard.wait()  # Aguarda infinitamente
