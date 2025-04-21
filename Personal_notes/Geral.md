# Criando um novo projeto
    dotnet new web

    * Lista de templates: 
    https://stackoverflow.com/questions/66723760/creating-an-empty-asp-net-core-project-in-vscode



# Rodando o projeto

## Compilar e executar
    dotnet run

## Acessar o container Docker
    docker exec -it ID_CONTAINER /bin/bash

    * Ver os arquivos do container
        ls -la

    * Error "Cannot connect to the Docker daemon ..."
        systemctl start docker

    * Error "Premissão negada"
        sudo gpasswd -a $USER docker

    * Erro persite - verificar contexto e mudar para default
        docker context ls 
        docker context use default 

### Mudando de contexto entre docker desktop e docker engine
    docker context ls 

* Docker Engine
    docker context use default 

* Docker Desktop
    docker context use desktop-linux

Help:
https://docs.docker.com/desktop/setup/install/linux/



# Criando imagem e container docker para a API

* Criar arquivo Dockerfile usando a extensão de Docker do VSCode

* Construir imagem do projeto
    docker build -t aspnetapp:1.0 -f Dockerfile .

* Pegar o id imagem
    docker images

* Criar container a partir de imagem
    docker run --name news_aspnet -i -t ID_IMAGE /bin/bash

* Consultar containers
    docker ps -a



# Usando uma imagem MongoDB do Docker

* Download da imagem
    docker pull mongo

* Executando a imagem
    docker run --name mongodb -p 27017:27017 -e AUTH=no mongo

* Dando start no banco
    docker start ID_CONTAINER



# Adicionando pacotes
    dotnet add package <PACKAGE_NAME>

* Exemplo:
    dotnet add package MongoDB.Bson

## Alguns pacotes usados

* Swagger: dotnet add aspnetapp5.csproj package Swashbuckle.AspNetCore -v 6.6.2
* AutoMapper: dotnet add package AutoMapper
* MongoDB Driver: dotnet add package MongoDB.Driver
* MongoDB Bson: dotnet add package MongoDB.Bson


# Manuseando o Banco de Dados Mongo

## App robo3t

* Instalação:
    https://snapcraft.io/install/robo3t-snap/debian#install

* Executar o app (em caso de erro com o wayland):
    DISABLE_WAYLAND=1 robo3t-snap
    