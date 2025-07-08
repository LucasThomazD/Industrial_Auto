import os, sys, shutil, re, time
from pathlib import Path
from manipular import GerenciadorArquivo

class toolsArq:
    def mover_consolidados(pasta_inicial):
        for raiz, _, arquivos in os.walk(pasta_inicial):
            raiz_path = Path(raiz)
            for arquivo in arquivos:
                if re.search(r'(?i)\bconsolidado\b', arquivo):
                    caminho_arquivo_origem = raiz_path / arquivo
                    caminhoPasta = Path(pasta_inicial)
                    pasta_destino = caminhoPasta / "Consolidado"
                    pasta_destino.mkdir(parents=True, exist_ok=True)
                    caminho_arquivo_destino = pasta_destino / arquivo
                    shutil.move(str(caminho_arquivo_origem), str(caminho_arquivo_destino))
                    arquivotxt.atualizar_arquivo(f"Arquivo {arquivo} movido para a pasta Consolidado")
                    time.sleep(3)
                    arquivotxt.atualizar_arquivo("Tarefa Concluida")
                    

    def buscar_e_mover_arquivos(pasta_inicial, palavra="Área", num_caracteres=5):
        layout_padrao = {
            'Financ': '001. Comp Físico e Financ. Redes',
            'Elétrica': '003. Comp. Elétrica',
            'Instrumentação': '004. Comp. Instrum',
            'Tubulação': '005. Comp. Tubulação',
            'Sup. Tub': '006. Comp. Sup. de Tub',
            'CBINC': '007. Comp. Comb. a Inc.',
            'Instrumentos': '008. Comp. de Instrumentos',
            'Calc Serviços': '009. M.C de Serviços',
            'CPU': '010. Comp. de Preços Unit. Redes.',
            'PPQ': '011. Plan. de Preços e quant. Redes'
        }
        
        layouts_por_area = {
            'Área 2511': {
                'Financ': '001. Comp Físico e Financ. Redes',
                'Elétrica': '003. Comp. Elétrica',
                'Instrumentação': '004. Comp. Instrum',
                'Instrumentos': '005. Comp. de Instrumentos',
                'Calc Serviços': '006. M.C de Serviços',
                'CPU': '007. Comp. de Preços Unit. Redes.',
                'PPQ': '008. Plan. de Preços e quant. Redes'
            },
            'Área 2744': {
                'Financ': '001. Comp Físico e Financ. Redes',
                'Elétrica': '003. Comp. Elétrica',
                'Instrumentação': '004. Comp. Instrum',
                'CBINC': '005. Comp. Comb. a Inc.',
                'Instrumentos': '006. Comp. de Instrumentos',
                'Calc Serviços': '007. M.C de Serviços',
                'CPU': '008. Comp. de Preços Unit. Redes.',
                'PPQ': '009. Plan. de Preços e quant. Redes'
            },
            'Área 7816': {
                'Financ': '001. Comp Físico e Financ. Redes',
                'Elétrica': '003. Comp. Elétrica',
                'Instrumentação': '004. Comp. Instrum',
                'CBINC': '005. Comp. Comb. a Inc.',
                'Instrumentos': '006. Comp. de Instrumentos',
                'Calc Serviços': '007. M.C de Serviços',
                'CPU': '008. Comp. de Preços Unit. Redes.',
                'PPQ': '009. Plan. de Preços e quant. Redes'
            },
            'Área 7818': {
                'Financ': '001. Comp Físico e Financ. Redes',
                'Elétrica': '003. Comp. Elétrica',
                'Instrumentação': '004. Comp. Instrum',
                'CBINC': '005. Comp. Comb. a Inc.',
                'Instrumentos': '006. Comp. de Instrumentos',
                'Calc Serviços': '007. M.C de Serviços',
                'CPU': '008. Comp. de Preços Unit. Redes.',
                'PPQ': '009. Plan. de Preços e quant. Redes'
            }
        }
        
        for raiz, _, arquivos in os.walk(pasta_inicial):
            raiz_path = Path(raiz)
            for arquivo in arquivos:
                caminho_arquivo_origem = raiz_path / arquivo
                
                if palavra.lower() in arquivo.lower():
                    pos = arquivo.lower().find(palavra.lower())
                    nome_da_pasta = arquivo[pos + len(palavra):pos + len(palavra) + num_caracteres].strip()
                    if nome_da_pasta:
                        nome_completo_da_pasta = f"{palavra} {nome_da_pasta}"
                        caminhoPasta = Path(pasta_inicial)
                        pasta_destino = caminhoPasta / nome_completo_da_pasta
                        pasta_destino.mkdir(parents=True, exist_ok=True)
                        
                        area_encontrada = next((area for area in layouts_por_area if area.lower() in arquivo.lower()), None)
                        disciplinas_layout = layouts_por_area.get(area_encontrada, layout_padrao)
                        
                        disciplina_encontrada = next((nome for chave, nome in disciplinas_layout.items() if chave.lower() in arquivo.lower()), None)
                        if disciplina_encontrada:
                            pasta_disciplina = pasta_destino / disciplina_encontrada
                            pasta_disciplina.mkdir(parents=True, exist_ok=True)
                            caminho_arquivo_destino = pasta_disciplina / arquivo
                            shutil.move(str(caminho_arquivo_origem), str(caminho_arquivo_destino))
                            arquivotxt.atualizar_arquivo(f"Arquivo {arquivo} movido para a subpasta {pasta_disciplina}")
                            time.sleep(3)
                            arquivotxt.atualizar_arquivo("Tarefa Concluida")
                        else:
                            caminho_arquivo_destino = pasta_destino / arquivo
                            shutil.move(str(caminho_arquivo_origem), str(caminho_arquivo_destino))
                            arquivotxt.atualizar_arquivo(f"Arquivo {arquivo} movido para a pasta {pasta_destino}")
                            time.sleep(3)
                            arquivotxt.atualizar_arquivo("Tarefa Concluida")
                    else:
                        arquivotxt.atualizar_arquivo(f"Não foi possível extrair os caracteres após a palavra '{palavra}' do arquivo {arquivo}.")
                        time.sleep(3)
                        arquivotxt.atualizar_arquivo("Tarefa Concluida")


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
                    arquivotxt.atualizar_arquivo(f"Movido: {caminho_original} -> {caminho_destino}")
                    time.sleep(3)
                    arquivotxt.atualizar_arquivo("Tarefa Concluida")
                else:
                    shutil.copy2(caminho_original, caminho_destino)
                    arquivotxt.atualizar_arquivo(f"Copiado: {caminho_original} -> {caminho_destino}")
                    time.sleep(3)
                    arquivotxt.atualizar_arquivo("Tarefa Concluida")


arquivotxt = GerenciadorArquivo("include/log.txt")