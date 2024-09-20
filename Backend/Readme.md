<h1 style="text-align: center;">PawsHappy - Backend</h1>
<p style="text-align: center;">API para la Plataforma de Adopción de Mascotas</p>

## Descripción del Proyecto

El backend de **PawsHappy** está desarrollado con **.NET 8** y ofrece una API que gestiona mascotas, usuarios y adopciones. Esta API se comunica con una base de datos y expone endpoints para realizar las operaciones CRUD necesarias para la plataforma de adopción.

## Características

- **Gestión de mascotas:** CRUD de mascotas disponibles para adopción.
- **Gestión de usuarios:** Registro y autenticación de usuarios.
- **Gestión de adopciones:** Los usuarios pueden solicitar la adopción de mascotas.
- **Swagger:** Documentación de la API para pruebas y desarrollo.

## Tecnologías Utilizadas

- **.NET 8**
- **Entity Framework Core**
- **SQL Server** (producción)
- **SQLite** (desarrollo)
- **Swagger** para la documentación de la API

## Estructura del Proyecto

- **Controladores:** Manejan las peticiones HTTP para mascotas, usuarios y adopciones.
- **DbContext:** Configura las entidades y relaciones de la base de datos.
- **Servicios:** Lógica de negocio que soporta las operaciones de la API.
