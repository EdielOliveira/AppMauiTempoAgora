<h2 align="center"> App MAUI - Tempo Agora </h2>

<div align="center">
  
<img width="300" height="150" alt="logo_tempo_agora" src="https://github.com/user-attachments/assets/d7eec4a0-2af0-4f36-a42e-8becf79d2413" />

![GitHub repo size](https://img.shields.io/github/repo-size/EdielOliveira/AppMauiTempoAgora?style=for-the-badge)

[![My Skills](https://skillicons.dev/icons?i=dotnet,cs,visualstudio&theme=dark)](https://skillicons.dev)

</div>

<div align="center">

![image](http://www.unow.com.br/emDesenvolvimento.gif)

<img src="http://img.shields.io/static/v1?label=STATUS&message=%20FINALIZADO&color=YELLOW&style=for-the-badge"/>

</div>

<div align="center">
  
## Índice
  
- [Abrindo o Código](#-abrindo-o-código)
- [Visão Geral](#visão-geral)
- [Arquitetura do App](#arquitetura-do-app)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Funcionalidades](#funcionalidades)
- [Desenvolvedor](#-desenvolvedor)

</div>

<h1 align="left">
🚀 Abrindo o Código
</h1>

Este projeto está disponibilizado **exclusivamente para fins de estudo, análise de código e aprendizado sobre desenvolvimento mobile com .NET MAUI**.

⚠️ **Aviso importante:**  
A execução do aplicativo **não está disponível diretamente para usuários finais**, pois requer:

- Ambiente configurado com **.NET MAUI**
- **Visual Studio** com workloads mobile
- Emulador Android ou dispositivo físico
- Configuração de acesso à **API de clima**

📌 Recomenda-se:
- Analisar a **estrutura do projeto**
- Ler os arquivos **XAML e C#**
- Avaliar a organização do app
- Entender o consumo de dados climáticos

A disponibilização de uma versão compilada poderá ser considerada futuramente.

<h1 align="center">
Visão Geral
</h1>

Este repositório contém um **aplicativo mobile de clima (Tempo Agora)**, desenvolvido em **.NET MAUI**, utilizando **C# e XAML**.

O aplicativo permite que o usuário informe o nome de uma cidade e, em seguida, realize uma **consulta em tempo real** a uma API de clima, exibindo informações meteorológicas atualizadas, como:

- Temperatura atual
- Condição do tempo
- Umidade do ar
- Velocidade do vento
- Horários de nascer e pôr do sol

O projeto foi desenvolvido como parte de atividades acadêmicas do curso técnico em **Desenvolvimento de Sistemas**, com foco em **aplicações multiplataforma**.


<div align="center">
  
<img width="500" height="500" alt="Imagem Função App" src="https://github.com/user-attachments/assets/537e3927-7c37-4997-875a-3b19376dcaa8" />

</div>

A interface foi projetada para ser simples e intuitiva, permitindo ao usuário consultar rapidamente as condições climáticas de qualquer cidade informada.

<h1 align="center">
Arquitetura do App
</h1>

O aplicativo segue uma arquitetura simples e bem organizada, comum em projetos **.NET MAUI**, separando responsabilidades entre interface, lógica e modelos de dados.

- **XAML:** Responsável pela interface gráfica
- **Code-behind (C#):** Controle da lógica de exibição e eventos
- **Models:** Representação dos dados retornados pela API de clima

Essa abordagem garante clareza, organização e facilidade de manutenção.

<h1 align="center">
Estrutura do Projeto
</h1>

<div align="left">

📁 **AppMauiTempoAgora/**  
Projeto principal do aplicativo MAUI

- `App.xaml / App.xaml.cs` – Inicialização global do app  
- `AppShell.xaml / AppShell.xaml.cs` – Estrutura de navegação  
- `MainPage.xaml / MainPage.xaml.cs` – Tela principal do aplicativo  
- `MauiProgram.cs` – Configuração do app e serviços  

📁 **Models/**  
Contém os modelos de dados utilizados no consumo da API:

- `Tempo.cs` – Modelo responsável por mapear os dados climáticos (temperatura, umidade, vento, sol, etc.)

📁 **Platforms/**  
Configurações específicas de cada plataforma:

- `Android/` – Configurações e manifest do Android  
- Estrutura preparada para multiplataforma (Android, Windows, etc.)

📄 **AppMauiTempoAgora.sln**  
Arquivo de solução do Visual Studio

</div>

<h1 align="center">
Funcionalidades
</h1>

<div align="left">

- Consulta de dados climáticos em tempo real
- Busca por cidade
- Exibição da temperatura atual
- Condição climática
- Umidade do ar
- Velocidade do vento
- Horário do nascer e pôr do sol
- Interface simples e intuitiva
- Aplicação multiplataforma com .NET MAUI
 
</div>

<h1 align="center">🤝 Desenvolvedor</h1>

<table align="center">
    <td align="center">
      <a href="#">
        <img src="https://avatars.githubusercontent.com/u/113260177?s=400&v=4" width="150px;" alt="Foto do Desenvolvedor"/><br>
        <sub>
          <b>EdielOliveira</b>
        </sub>
      </a>
    </td>   
</table>
