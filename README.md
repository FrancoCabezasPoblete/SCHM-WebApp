# Grupo 11

Este es el repositorio del *Grupo 11*, cuyos integrantes son:

* Franco Cabezas - 201973082-7
* Ángelo Miranda - 201973126-2
* Paulina Vega - 201973052-5
* **Tutor**: Ibet Lara

## Wiki

Puede acceder a la Wiki mediante el siguiente [enlace](https://gitlab.labcomp.cl/wladimir.ormazabal.ex/inf236-2021-2-grupo-11-p-002/-/wikis/Inicio)

## Videos

* [Video presentación cliente](https://youtu.be/xEYDTg0q1Ao)
* [Video presentación avance 1](https://drive.google.com/file/d/1TgpT9KZK0LEM13Am4jzxLIDdpv983Rkg/view?usp=sharing)
* [Video presentación avance 3](https://youtu.be/6jFGHFcWH8g)
* Video presentación final (https://drive.google.com/file/d/11nZdjhj8FbFDMdNGKyf7tcAOS66rn8JG/view?usp=sharing)

## Aspectos técnicos relevantes

*Por ejemplo, como poder levantar el proyecto, etc...*

El proyecto de ejemplo se baso en la documentación disponible en:

* [MVC Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0&tabs=visual-studio-code)
* [.Net Core + Docker](https://code.visualstudio.com/docs/containers/quickstart-aspnet-core)

Desarrollado con [Docker](https://www.docker.com/) y complementos de [Visual Studio Code](https://code.visualstudio.com/)

**Importante:** Requiere tener [Docker](https://www.docker.com/) instalado. Para levantar el proyecto ejecutar los siguientes pasos:
1. ```docker-compose -f docker-compose.yml build --no-cache```
2. ```docker-compose -f docker-compose.yml up -d```
3. Acceder a http://localhost:5000/

Puede validar la creación de la imagen y contenedor:

1. ```docker images```
2. ```docker ps -a```
