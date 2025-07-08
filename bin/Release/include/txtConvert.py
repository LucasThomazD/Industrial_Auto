from num2words import num2words
import tkinter as tk
from tkinter import messagebox
import keyboard  # Biblioteca para capturar atalhos globais


def corrigir_padrao_brasileiro(texto):
    """
    Corrige palavras do padrão europeu para o padrão brasileiro.
    """
    substituicoes = {
        "dezanove": "dezenove",
        "dezasseis": "dezesseis",
        "dezassete": "dezessete",
    }
    for europeu, brasileiro in substituicoes.items():
        texto = texto.replace(europeu, brasileiro)
    return texto


def converter_e_copiar(valor=None):
    try:
        # Obtém o valor do campo de entrada ou da área de transferência
        if valor is None:
            valor = entrada_valor.get().strip()
        
        if not valor:
            messagebox.showwarning("Aviso", "Por favor, insira um valor!")
            return

        # Substitui vírgulas por pontos para tratar como float
        valor = float(valor.replace(',', '.'))

        # Separa a parte inteira e a decimal (centavos)
        parte_inteira = int(valor)
        parte_decimal = int(round((valor - parte_inteira) * 100))

        # Converte a parte inteira para extenso
        reais_extenso = num2words(parte_inteira, lang='pt') + (" real" if parte_inteira == 1 else " reais")

        # Converte a parte decimal para extenso (centavos)
        if parte_decimal > 0:
            centavos_extenso = num2words(parte_decimal, lang='pt') + (" centavo" if parte_decimal == 1 else " centavos")
            valor_extenso = f"{reais_extenso} e {centavos_extenso}"
        else:
            valor_extenso = reais_extenso

        # Corrige para o padrão brasileiro
        valor_extenso = corrigir_padrao_brasileiro(valor_extenso)

        # Exibe o resultado no rótulo
        resultado.config(text=f"{valor_extenso}")

        # Copia o resultado para a área de transferência
        janela.clipboard_clear()
        janela.clipboard_append(f"{valor_extenso}")
    except ValueError:
        messagebox.showerror("Erro", "Digite um valor numérico válido.")


def colar_converter_e_copiar():
    try:
        # Obtém o texto da área de transferência
        valor_colado = janela.clipboard_get()
        entrada_valor.delete(0, tk.END)  # Limpa o campo de entrada
        entrada_valor.insert(0, valor_colado)  # Cola o valor no campo
        converter_e_copiar(valor_colado)  # Realiza a conversão e copia o resultado
    except tk.TclError:
        messagebox.showerror("Erro", "A área de transferência está vazia ou contém dados inválidos.")


def atalho_global():
    try:
        # Obtém o texto da área de transferência usando tkinter
        valor_colado = janela.clipboard_get()
        entrada_valor.delete(0, tk.END)  # Limpa o campo de entrada
        entrada_valor.insert(0, valor_colado)  # Cola o valor no campo
        converter_e_copiar(valor_colado)  # Realiza a conversão e copia o resultado
    except tk.TclError:
        messagebox.showerror("Erro", "A área de transferência está vazia ou contém dados inválidos.")


# Configura o atalho global (Ctrl + \)
keyboard.add_hotkey("ctrl+\\", atalho_global)

# Cria a janela principal
janela = tk.Tk()
janela.title("Conversor de Valor por Extenso")
janela.geometry("400x300")

# Rótulo de instrução
instrucao = tk.Label(janela, text="Digite um valor em reais:", font=("Arial", 12))
instrucao.pack(pady=10)

# Campo de entrada
entrada_valor = tk.Entry(janela, font=("Arial", 12), width=20)
entrada_valor.pack(pady=5)

# Botão "Converter e Copiar"
botao_converter_copiar = tk.Button(
    janela, text="Converter e Copiar", command=converter_e_copiar, font=("Arial", 12), bg="lightblue"
)
botao_converter_copiar.pack(pady=5)

# Botão "Colar, Converter e Copiar"
botao_colar_converter_copiar = tk.Button(
    janela, text="Colar, Converter e Copiar", command=colar_converter_e_copiar, font=("Arial", 12), bg="lightgreen"
)
botao_colar_converter_copiar.pack(pady=5)

# Rótulo para exibir o resultado
resultado = tk.Label(janela, text="", font=("Arial", 12), fg="green")
resultado.pack(pady=10)

# Inicia o loop principal da interface
janela.mainloop()

