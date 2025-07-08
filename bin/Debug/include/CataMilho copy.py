import os
import shutil
import tkinter as tk
from tkinter import filedialog, messagebox

def selecionar_pasta(titulo):
    """Abre um diálogo para selecionar uma pasta."""
    root = tk.Tk()
    root.withdraw()
    return filedialog.askdirectory(title=titulo)

def perguntar_renomear():
    """Pergunta ao usuário se deseja renomear os arquivos."""
    root = tk.Tk()
    root.withdraw()
    return messagebox.askyesno("Renomear arquivos", "Deseja renomear os arquivos com o nome da pasta?")

def perguntar_modo_transferencia():
    """Pergunta ao usuário se deseja copiar ou mover os arquivos."""
    root = tk.Tk()
    root.withdraw()
    return messagebox.askyesno("Modo de Transferência", "Deseja MOVER os arquivos? (Sim = MOVER / Não = COPIAR)")

def transferir_arquivos(pasta_raiz, pasta_destino, renomear, mover):
    """Transfere os arquivos das subpastas para a pasta de destino, com ou sem renomeação."""
    if not os.path.exists(pasta_destino):
        os.makedirs(pasta_destino)

    for pasta_atual, _, arquivos in os.walk(pasta_raiz):
        nome_pasta = os.path.basename(pasta_atual)  # Nome da pasta de origem
        for arquivo in arquivos:
            caminho_original = os.path.join(pasta_atual, arquivo)

            if renomear:
                nome_original, extensao = os.path.splitext(arquivo)  # Separando nome e extensão
                novo_nome = f"{nome_pasta}{extensao}"  # Criando novo nome corretamente

                # Evita sobrescrita adicionando número incremental se necessário
                contador = 1
                caminho_destino = os.path.join(pasta_destino, novo_nome)
                while os.path.exists(caminho_destino):
                    novo_nome = f"{nome_pasta}_{contador}{extensao}"
                    caminho_destino = os.path.join(pasta_destino, novo_nome)
                    contador += 1
            else:
                caminho_destino = os.path.join(pasta_destino, arquivo)  # Mantém o nome original

            if mover:
                shutil.move(caminho_original, caminho_destino)
                print(f"Movido: {caminho_original} -> {caminho_destino}")
            else:
                shutil.copy2(caminho_original, caminho_destino)
                print(f"Copiado: {caminho_original} -> {caminho_destino}")

pasta_raiz = selecionar_pasta("Selecione a PASTA RAIZ")
if not pasta_raiz:
    print("Nenhuma pasta raiz selecionada. Saindo...")
    exit()

pasta_destino = selecionar_pasta("Selecione a PASTA DE DESTINO")
if not pasta_destino:
    print("Nenhuma pasta de destino selecionada. Saindo...")
    exit()

# Perguntar se o usuário deseja renomear os arquivos
renomear = perguntar_renomear()

# Perguntar se o usuário deseja copiar ou mover os arquivos
mover = perguntar_modo_transferencia()

# Executar a transferência (copiar ou mover)
transferir_arquivos(pasta_raiz, pasta_destino, renomear, mover)

tk.messagebox.showinfo(title="Conclusão", message=f"Arquivos Processador com sucesso em: {pasta_destino}")