<h1 align="center">API News - C#, .NET e MongoDB</h1>

<p>[Em desenvolvimento] Projeto desenvolvido em acompanhamento ao curso da Udemy "Aprenda nesse curso como desenvolver uma API RESTful do zero com .NET, MongoDB, Redis e Docker". O objetivo foi estudar o uso de .NET, Docker e MongoDB para construir uma API. O Resultado esperado é um CRUD "Dockerizado" persistindo no MongoDB.</p>

<p>[Frontend em Angular](), usado junto ao projeto [TODO].</p>


# Índice

* [Status do projeto](#Status-do-projeto)
* [Tecnologias utilizadas](#Tecnologias-utilizadas)
* [Conceitos trabalhados](#conceitos-trabalhados)
* [Configuração do ambiente de teste](#Configuração-do-ambiente-de-teste)
* [Referências](#Referências)


# Status do projeto

🚧 Em desenvolvimento 🚧


# Tecnologias utilizadas

- [C#](https://dotnet.microsoft.com/pt-br/languages/csharp)
- [.NET](https://dotnet.microsoft.com/pt-br/download)
- [Docker](https://docs.docker.com/)
- [MongoDB](https://www.mongodb.com/)
- [AutoMapper](https://automapper.org/)
- [ImageProcessor](https://jimbobsquarepants.github.io/ImageProcessor/)


# Conceitos trabalhados

* C#, MongoDB e Docker
* Uso de .NET 5, 6, e versões superiores
* Arquitetura básica e injeção de dependencias no .NET
* Trabalhar com AutoMapper
* Validar os endpoints através do Swagger
* Upload e compressão de imagens
* Angular para o frontend [TODO]
* Autenticação com JWT [TODO]
* Testes unitários em uma aplicação .NET [TODO]
* HealthCheck para o app [TODO]
* Redis para Cache em memoria [TODO]


# Configuração do ambiente de teste

## Pré-requisitos

- **.NET SDK** versão 6 ou superior;
- **Docker** Engine ou Desktop;

## Usando a API

1. Faça o clone do repositório e no terminal navegue até a pasta.
2. Para iniciar o server local usando o VSCode, execute o comando `dotnet run`.
3. Para acessar o server basta copiar o endereço obtido no terminal, incluir `/swagger/index.html`, e abrir no navegador web. Exemplo: `http://localhost:5130/swagger/index.html`.
4. Para testar o CRUD, configure o banco de dados MongoDB seguindo os passos do tópico abaixo, [Usando o MongoDB com imagem Docker](#usando-o-mongodb-com-imagem-docker).


## Usando o MongoDB com imagem Docker

### Configurando o MongoDB com Docker no PC pela primeira vez

* Download da imagem
    docker pull mongo

* Criação do container a partir da imagem baixada
    docker run --name mongodb -p 27017:27017 -e AUTH=no mongo

- [Mais sobre a imagem](https://hub.docker.com/_/mongo)


### Iniciando o container MongoDB criado (caso inativo)

* Consultar containers (ativos e inativos) 
    docker ps -a

* Iniciar o container
    docker start ID_CONTAINER


## Gerenciamento de dados usando MongoDB

[TODO]

# Referências

Instalar o SDK do .NET ou o runtime do .NET no Debian:
https://learn.microsoft.com/pt-br/dotnet/core/install/linux-debian?tabs=dotnet9

.NET 8 Linux package dependencies:
https://github.com/dotnet/core/blob/main/release-notes/8.0/linux-packages.md

C# Dev Kit - Visual Studio Code:
https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit

Creating an empty asp.net core project in vscode:
https://stackoverflow.com/questions/66723760/creating-an-empty-asp-net-core-project-in-vscode

Install Docker Desktop on Linux:
https://docs.docker.com/desktop/setup/install/linux/

Enable snaps on Debian and install robo3t-snap:
https://snapcraft.io/install/robo3t-snap/debian#install

DI (Dependency Injection):
https://github.com/LuanRoger/AllInOneAspNet#di-dependency-injection

ImageFactory is generating .webp file that is larger than .jpeg file:
https://stackoverflow.com/questions/60233979/imagefactory-is-generating-webp-file-that-is-larger-than-jpeg-file