# Fizz Buzz

Este proyecto implementa un servicio web WCF que expone un método para generar la serie de Fizz Buzz. Además, registra la serie generada en un archivo junto con un timestamp. El servicio web sigue una arquitectura DDD y utiliza diferentes principios SOLID, junto con las siguientes tecnologías y herramientas: Autofac para la inyección de dependencias, Logger Log4Net para el registro de eventos, y una estructura de capas bien definida.

## Requisitos previos

- [Visual Studio](https://visualstudio.microsoft.com/) o un entorno de desarrollo compatible.
- [.NET Framework 4.8](https://dotnet.microsoft.com/download) instalado en tu máquina.
- Conocimientos básicos de WCF, Autofac y Log4Net.

## Estructura del proyecto

El proyecto sigue la estructura de una arquitectura DDD, que se organiza en diferentes capas:

- **Distributed Web Service Layer**
  - `VuelingExam.Distributed.WebServices`
    - `IVuelingWebService.cs`: Define la interfaz del servicio web WCF.
    - `VuelingWebService.svc`: Punto de entrada del servicio web WCF.
    - `Configuration`
      - `AutofacConfiguration`: Configuración de Autofac para la inyección de dependencias.

- **Application Layer**
  - `VuelingExam.Application.Services`
    - `AutofacModule`
      - `AppServiceModule`: Configuración de Autofac para la capa de servicios de aplicación.
    - `Contracts`
      - `IFizzBuzzAppService.cs`: Define la interfaz del servicio de aplicación para Fizz Buzz.
    - `Implementation`
      - `FizzBuzzAppService.cs`: Implementación del servicio de aplicación para Fizz Buzz.

- **Infrastructure Layer**
  - `VuelingExam.Infrastructure.Repository`
    - `AutofacModule`
      - `RepositoryModule`: Configuración de Autofac para la capa de repositorio.
    - `Contracts`
      - `IFizzBuzzRepository`: Define la interfaz del repositorio de Fizz Buzz.
    - `Implementation`
      - `FizzBuzzRepository.cs`: Implementación del repositorio de Fizz Buzz.

  - `VuelingExam.Infrastructure.Util`
    - `Contracts`
      - `IWriteList.cs`: Define la interfaz para escribir en el archivo de registro.
    - `Implementation`
      - `WriteList.cs`: Implementación para escribir en el archivo de registro.

Además de estas capas, también encontrarás otros archivos y carpetas del proyecto que son necesarios para su funcionamiento.

## Uso del proyecto

Para utilizar el proyecto, sigue estos pasos:

1. Configura el servicio web WCF en tu servidor de alojamiento preferido, como IIS.
2. Realiza una solicitud al servicio web utilizando la ruta y los parámetros adecuados para generar la serie de Fizz Buzz.


## Problemas conocidos

- Se ha intentado implementar la funcionalidad utilizando el método "POST", pero ha habido errores y se ha optado por utilizar el método "GET" en su lugar.

- No se ha realizado la prueba unitaria de la clase "WriteList". La dependencia depende directamente de la clase con el sistema de archivos a través de la clase "File" dificulta la prueba unitaria. Esto puede resultar en una cobertura de prueba insuficiente y en una menor confiabilidad de las pruebas realizadas.


