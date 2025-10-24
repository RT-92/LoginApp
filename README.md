# 🔐 LoginApp – Sistema de Autenticación con Roles y Panel de Administración

![C#](https://img.shields.io/badge/C%23-Visual%20Studio-blue?logo=csharp)
![WinForms](https://img.shields.io/badge/Windows%20Forms-UI-green?logo=windows)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red?logo=microsoftsqlserver)
![Estado](https://img.shields.io/badge/Estado-En%20Desarrollo-yellow)


---

## 🧠 Descripción

**LoginApp** es una aplicación de escritorio desarrollada en **C# + Windows Forms + SQL Server**, que implementa un sistema completo de autenticación con:

- 🔒 Validación de contraseñas usando SHA2_256  
- 🚫 Bloqueo automático tras múltiples intentos fallidos  
- 🛠️ Panel de administración para desbloquear cuentas y editar roles  
- 🧱 Arquitectura en capas (UI, lógica, datos, utilitarios)  
- 📦 Código limpio, modular y documentado para portafolio profesional  

Este repositorio incluye tanto la versión inicial como la versión mejorada del sistema, reflejando mi evolución como desarrollador.

---

## 🧩 Estructura del Proyecto

/LoginApp \
├── /Forms # Formularios de la interfaz \
<!--├── /Models # Entidades (Usuario) \-->
├── /Data # Acceso a datos (SqlConnectionHelper, Repositorios) \
├── /Utils # Seguridad y clases auxiliares (HashGenerator) \
<!-- ├── /Docs # Diagramas UML, scripts SQL, documentación \-->
<!--├── /Tests # Pruebas unitarias (xUnit) \-->
├── README.md # Este archivo \
└── LoginApp.sln # Solución principal\

<!--  -->


---

## 🛠️ Tecnologías utilizadas

| Tecnología       | Propósito                         |
|------------------|-----------------------------------|
| C# (.NET)        | Lógica de negocio y UI            |
| Windows Forms    | Interfaz gráfica de escritorio    |
| SQL Server       | Base de datos relacional          |
| SHA2_256         | Seguridad en contraseñas          |
| Git + GitHub     | Control de versiones y portafolio |
<!--| Mermaid          | Diagramas UML en README           |-->

---

## 📌 Historial de versiones

| Versión | Descripción | Mejoras clave |
|--------|-------------|----------------|
| `v1.0` | Login básico con bloqueo | Validación SHA2_256, panel admin simple |
| `v2.0` | Arquitectura en capas + clase Usuario | Separación UI/lógica/datos, repositorio, documentación UML |
| `v3.0` *(próxima)* | Seguridad avanzada | Salting, PBKDF2, pruebas unitarias, mejoras visuales |

---

## 👨‍💻 Sobre mí

Soy Rodrigo, desarrollador backend en formación. Me apasiona construir sistemas reales aplicando buenas prácticas, seguridad y arquitectura profesional. Este proyecto refleja mi evolución técnica y mi compromiso con el código limpio y documentado.

---

## 📎 Recursos incluidos

<!--|- ✅ Diagramas UML en Mermaid  -->
- ✅ Script SQL para crear la base de datos  
<!--|- ✅ Pruebas unitarias con xUnit  -->
- ✅ Documentación técnica y visual  

---

## 📥 Instalación

1. Cloná el repositorio  
   `git clone https://github.com/tuusuario/LoginApp.git`
2. Abrí `LoginApp.sln` en Visual Studio  
3. Configurá tu cadena de conexión en `SqlConnectionHelper.cs`  
4. Ejecutá el script SQL en tu servidor  
5. ¡Listo para probar!

---

## 📄 Licencia

Este proyecto está bajo la licencia MIT.  
Podés usarlo, modificarlo y compartirlo libremente.

---

