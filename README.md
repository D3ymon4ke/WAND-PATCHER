<div align="center">

<img src="./assets/icon.svg" alt="WAND-PATCHER Logo" width="160" height="160" />

# 🪄 WAND-PATCHER

### Extensão Avançada de UX, Interoperabilidade e Ativação Local para Wand (WeMod)

[![GitHub Repository](https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github)](https://github.com/D3ymon4ke/WAND-PATCHER)
[![Platform](https://img.shields.io/badge/Platform-Windows%2010%20%7C%2011-0078D6?style=for-the-badge&logo=windows)](https://github.com/D3ymon4ke/WAND-PATCHER)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue?style=for-the-badge)](LICENSE.md)
[![Framework](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Maintainer](https://img.shields.io/badge/Maintainer-Lucas%20Machado-7928CA?style=for-the-badge)](https://github.com/D3ymon4ke)

<p align="center">
  <b>Desenvolvido e mantido por Lucas Machado (@D3ymon4ke)</b>
</p>

---

</div>

## 🌟 Visão Geral

O **WAND-PATCHER** é uma ferramenta de código aberto desenvolvida em C# (.NET Framework 4.8 / WPF) e TypeScript/Preact projetada para aprimorar a experiência de uso do aplicativo Wand (WeMod), desbloqueando recursos Pro localmente, fornecendo um painel web remoto de baixa latência para smartphones e adicionando ferramentas avançadas de diagnóstico.

Todas as modificações ocorrem exclusivamente no cliente local, sem necessidade de servidores intermediários, envio de dados privados ou conexão obrigatória.

---

## ⚡ Principais Recursos

| Recurso | Descrição |
| :--- | :--- |
| 🔓 **Ativação Pro Local** | Desbloqueia os controles interativos (sliders, toggles, botões numéricos) e remove limites de uso e telas de assinatura no cliente. |
| 📱 **Remote Web Panel** | Permite controlar cheats diretamente do celular ou tablet conectado à mesma rede Wi-Fi via QR Code. |
| 🛡️ **Patch Estrutural** | Mecanismo de localização de código inteligente que não quebra quando o Wand/WeMod atualiza suas versões minificadas. |
| 📴 **100% Offline e Privado** | Não coleta telemetria, não intercepta tokens de autenticação nem envia informações para a nuvem. |
| ⌨️ **DevTools Integrado (F12)** | Permite abrir as ferramentas de desenvolvedor do Chromium/Electron com a tecla `F12`. |
| 💾 **Backup & Restauração** | Cria automaticamente um backup completo do `app.asar` e `app.asar.unpacked` para você restaurar o aplicativo original com 1 clique a qualquer momento. |

---

## 📱 Painel de Controle Remoto (Mobile Web Panel)

O aplicativo inclui um servidor local ultra-leve em WebSocket/HTTP na porta `3223`:

1. Abra o Wand já modificado.
2. Posicione o cursor sobre o botão **Connect** na barra superior para exibir o **QR Code**.
3. Aponte a câmera do seu celular (conectado ao mesmo Wi-Fi do computador) para escanear o código.
4. Controle os cheats, valores numéricos e ações dos jogos diretamente pela tela do smartphone sem sair do jogo!

---

## 🚀 Como Usar

### Execução Direta:
1. Feche o Wand/WeMod se ele estiver em execução.
2. Abra o executável **`WandEnhancer.exe`**.
3. O patcher detectará automaticamente o diretório de instalação do Wand (geralmente em `%LOCALAPPDATA%\Wand\app-X.XX.X`).
4. Clique em **Aplicar / Enhance** e selecione as opções desejadas.
5. Inicie o Wand e aproveite todos os recursos desbloqueados!

> **Dica de Restauração:** Para voltar à versão original limpa do Wand, basta abrir o `WandEnhancer.exe` e clicar em **Restaurar**.

---

## 🛠️ Como Compilar a Partir do Código-Fonte

Caso prefira compilar o executável no seu próprio computador:

### Requisitos:
- **Node.js** (v20 ou superior) e **pnpm** (`npm install -g pnpm`)
- **Visual Studio 2022** ou **Visual Studio Build Tools 2022** com suporte a .NET Desktop e `MSBuild`
- **.NET Framework 4.8 Targeting Pack / SDK**

### Passo a passo:
```bash
# 1. Clone o repositório
git clone https://github.com/D3ymon4ke/WAND-PATCHER.git
cd WAND-PATCHER

# 2. Execute o script automatizado de build
./build.cmd
```
O script cuidará de:
1. Instalar as dependências do painel web via `pnpm`.
2. Compilar os bundles Vite, TypeScript e o bridge Electron do painel remoto.
3. Executar a suíte de 49 testes automatizados.
4. Restaurar os pacotes NuGet e compilar a aplicação WPF em `Release`.
5. Gerar o executável final em `WandEnhancer/bin/Release/WandEnhancer.exe`.

---

## 📂 Estrutura do Projeto

```text
WAND-PATCHER/
├── assets/                  # Identidade visual, ícone SVG e capturas de tela
├── AsarSharp/               # Biblioteca de leitura, descompactação e empacotamento ASAR
├── WandEnhancer/            # Aplicação Desktop WPF (.NET 4.8) e motor de patches
│   ├── Core/                # Algoritmos de patch estrutural em JavaScript e fuses Electron
│   ├── Locale/              # Traduções da interface gráfica (12 idiomas)
│   └── View/                # Telas XAML e ViewModels
├── web-panel/               # Painel Web Remoto em Preact, Tailwind CSS e Vite
│   ├── bridge/              # Ponte IPC entre Electron e WebSocket LAN
│   └── src/                 # Interface mobile para controle de cheats
└── scripts/                 # Scripts de validação e testes de regressão
```

---

## ⚖️ Licença e Aviso Legal

- **Licença:** Distribuído sob a licença **Apache-2.0**. Consulte o arquivo [LICENSE.md](LICENSE.md) para obter mais detalhes.
- **Aviso Legal:** Este projeto é uma ferramenta de interoperabilidade desenvolvida para fins de personalização de interface local e estudo de arquitetura Electron. O projeto não hospeda nem distribui executáveis de terceiros ou dados protegidos por direitos autorais.

---

<div align="center">
  <sub>Criado com dedicação por <b>Lucas Machado</b> • 2026</sub>
</div>
