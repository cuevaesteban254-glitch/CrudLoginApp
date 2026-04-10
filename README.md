# 🚀 CRUD APP - Sistema de Gestión de Productos

<p align="center">
  <img src="https://img.shields.io/badge/STATUS-FUNCIONAL-green">
  <img src="https://img.shields.io/badge/.NET-ASP.NET%20Core-blue">
  <img src="https://img.shields.io/badge/Database-SQL%20Server-red">
</p>

---

## 📌 Descripción del Proyecto

Este proyecto es una aplicación web desarrollada con ASP.NET Core MVC que implementa un sistema CRUD (Crear, Leer, Actualizar y Eliminar) junto con autenticación de usuarios.

El sistema permite gestionar productos y restringe el acceso a usuarios autenticados.

---

## 🚧 Estado del proyecto

🚀 Proyecto funcional 🚀

---

## 🧠 Funcionalidades

- Registro de usuarios
- Inicio de sesión
- Cierre de sesión
- CRUD completo de productos
- Protección de rutas con [Authorize]
- Redirección automática al login

---

## 🔐 Seguridad

El sistema utiliza ASP.NET Core Identity para la autenticación.

Las rutas están protegidas con [Authorize], lo que evita que usuarios no autenticados accedan al sistema.

Si un usuario intenta ingresar directamente a una URL protegida, será redirigido al login.



## 📁 Acceso al proyecto

Clonar repositorio:

git clone https://github.com/cuevaesteban254-glitch/CrudLoginApp/edit/master/README.md

---

## ⚙️ Ejecutar el proyecto

1. Abrir en Visual Studio 2022  
2. Configurar base de datos en appsettings.json  
3. Ejecutar migraciones:

Update-Database

4. Ejecutar el proyecto

---

## 🗄️ Base de datos

Se utiliza SQL Server con las siguientes tablas:

- Productos
- AspNetUsers
- AspNetRoles

---

## 🛠️ Tecnologías utilizadas

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap
- Razor

---

## 👨‍💻 Autor

Esteban Cueva

---

## 📜 Licencia

Uso académico
