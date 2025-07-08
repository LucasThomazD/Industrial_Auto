#include <windows.h>
#include <iostream>
#include <string>

// Oculta janela de console (caso compile como app console)
void esconderJanela() {
    HWND hWnd = GetConsoleWindow();
    ShowWindow(hWnd, SW_HIDE);
}

// Lê texto do clipboard
std::string obterTextoDoClipboard() {
    std::string texto = "";

    if (OpenClipboard(NULL)) {
        HANDLE hData = GetClipboardData(CF_TEXT);
        if (hData != NULL) {
            char* pszText = static_cast<char*>(GlobalLock(hData));
            if (pszText != NULL) {
                texto = pszText;
                GlobalUnlock(hData);
            }
        }
        CloseClipboard();
    }

    return texto;
}

// Escreve texto no clipboard
void colocarTextoNoClipboard(const std::string& texto) {
    const size_t len = texto.length() + 1;
    HGLOBAL hMem = GlobalAlloc(GMEM_MOVEABLE, len);
    memcpy(GlobalLock(hMem), texto.c_str(), len);
    GlobalUnlock(hMem);

    OpenClipboard(0);
    EmptyClipboard();
    SetClipboardData(CF_TEXT, hMem);
    CloseClipboard();
}

// Converte número inteiro para extenso (até 10 por enquanto)
std::string numeroPorExtenso(int valor) {
    std::string nomes[] = {
        "zero", "um", "dois", "três", "quatro",
        "cinco", "seis", "sete", "oito", "nove", "dez"
    };

    if (valor >= 0 && valor <= 10)
        return nomes[valor];

    return std::to_string(valor); // fallback
}

// Junta valor em reais e centavos
std::string converterParaExtenso(const std::string& texto) {
    float valor = std::stof(texto);
    int reais = static_cast<int>(valor);
    int centavos = static_cast<int>((valor - reais) * 100 + 0.5f);

    std::string resultado = "";

    if (reais > 0)
        resultado += numeroPorExtenso(reais) + " reais";
    if (centavos > 0)
        resultado += " e " + numeroPorExtenso(centavos) + " centavos";

    return resultado;
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
    esconderJanela();

    // Registra Ctrl+Shift+E
    if (!RegisterHotKey(NULL, 1, MOD_CONTROL | MOD_SHIFT, 0x45)) {
        MessageBox(NULL, L"Erro ao registrar atalho", L"Conversor", MB_OK | MB_ICONERROR);
        return 1;
    }

    MSG msg = {0};
    while (GetMessage(&msg, NULL, 0, 0)) {
        if (msg.message == WM_HOTKEY) {
            std::string texto = obterTextoDoClipboard();
            std::string extenso = converterParaExtenso(texto);
            colocarTextoNoClipboard(extenso);
        }
    }

    return 0;
}
