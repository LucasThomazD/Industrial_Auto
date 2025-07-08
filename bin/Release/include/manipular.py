import os
# -*- coding: utf-8 -*-

class GerenciadorArquivo:
    def __init__(self, nome_arquivo):
        """Inicializa com o nome do arquivo."""
        self.nome_arquivo = nome_arquivo
    
    def criar_arquivo(self, conteudo=""):
        """Cria o arquivo e, opcionalmente, adiciona conteúdo."""
        with open(self.nome_arquivo, "w", encoding="utf-8") as f:
            f.write(conteudo)
        print(f"Arquivo '{self.nome_arquivo}' criado com sucesso!")


    def escrever_no_arquivo(self, conteudo, append=False):
        """Escreve no arquivo, sobrescrevendo ou adicionando ao conteúdo existente."""
        modo = "a" if append else "w"
        with open(self.nome_arquivo, modo, encoding="utf-8") as f:
            f.write(conteudo)
        print(f"Conteúdo escrito no arquivo '{self.nome_arquivo}'.")
    
    def limpar_arquivo(self):
        """Limpa o conteúdo do arquivo."""
        with open(self.nome_arquivo, "w", encoding="utf-8") as f:
            pass
        print(f"Arquivo '{self.nome_arquivo}' foi limpo.")
    
    def ler_arquivo(self):
        """Lê e retorna o conteúdo do arquivo."""
        if os.path.exists(self.nome_arquivo):
            with open(self.nome_arquivo, "r", encoding="utf-8") as f:
                conteudo = f.read()
            print(f"Conteúdo do arquivo '{self.nome_arquivo}':")
            return conteudo
        else:
            print(f"Arquivo '{self.nome_arquivo}' não existe.")
            return None
    
    def deletar_arquivo(self):
        """Exclui o arquivo."""
        if os.path.exists(self.nome_arquivo):
            os.remove(self.nome_arquivo)
            print(f"Arquivo '{self.nome_arquivo}' foi deletado com sucesso!")
        else:
            print(f"Arquivo '{self.nome_arquivo}' não existe.")

    def atualizar_arquivo(self, conteudo, append=False):
        with open(self.nome_arquivo, "w", encoding="utf-8") as f:
            pass
        modo = "a" if append else "w"
        with open(self.nome_arquivo, modo, encoding="utf-8") as f:
            f.write(conteudo)
        print(f"Conteúdo Atualizado no arquivo '{self.nome_arquivo}'.")

class toolspy:

    def conferirBool (item):
        if item == "True":
            item = True
            return item
        elif item == "False":
            item = False
            return item
        
    def conferirTxt(item):
        if item == "None":
            return None  # Retorna diretamente, sem redefinir a variável
        
        try:
            item = int(item)  # Converte para inteiro
            if item <= 0:
                return item
        except ValueError:
            pass  # Ignora erros de conversão caso `item` não seja um número

        return item  # Retorna o valor original caso não seja convertido
