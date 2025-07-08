from PDF_QuasePro import *
from tools import toolsArq
from manipular import GerenciadorArquivo, toolspy
import time

caso = int(sys.argv[1])
entrada = sys.argv[2]


def iniciar_func(func):
        match func:
            case 1:
                if len(sys.argv) > 5:  # Garantindo que há argumentos suficientes
                    pagina = int(sys.argv[3])
                    ordem = toolspy.conferirBool(sys.argv[5])                
                    adicionar = sys.argv[4]
                    alterar_pag.inserir_pdf(entrada, adicionar, pagina, antes=ordem)
                else:
                    print("Erro: Argumentos insuficientes para o caso 1.")
                return
              
            case 2:
                if len(sys.argv) > 3:
                    pagina = int(sys.argv[3])
                    alterar_pag.remover_pagina(entrada,entrada,pagina)
                else:
                     print("Erro: Argumentos insuficientes para o caso 2.")
                return
             
            case 3:
                if len(sys.argv) > 3:
                    pagina = int(sys.argv[3])
                    alterar_pag.copiar_pagina(entrada,pagina)
                else:
                     print("Erro: Argumentos insuficientes para o caso 2.")
                return
            
            case 4:
                    if len(sys.argv) > 5:
                        Graus = int(sys.argv[4])
                        Sentido = (sys.argv[5])
                        arquivotxt.atualizar_arquivo(Sentido)
                        pagina = toolspy.conferirTxt(sys.argv[3])
                        alterar_pag.rotacionar_pdf(entrada, entrada,pagina,graus=Graus, sentido=Sentido)
                    else:
                        print("Erro: Argumentos insuficientes para o caso 1.")
                    return    
            case 5:
                
                if len(sys.argv) > 3:
                    if not entrada.exists():
                        arquivotxt.atualizar_arquivo(f"Erro: A pasta inicial {entrada} não existe. Verifique o caminho.")
                        time.sleep(3)
                        arquivotxt.atualizar_arquivo("Tarefa Concluida")
                else:
                    toolsArq.mover_consolidados(entrada)
                    toolsArq.buscar_e_mover_arquivos(entrada)

arquivotxt = GerenciadorArquivo("include/log.txt")
iniciar_func(caso)
             