# ASP.NET Carnicería Rivas

Aplicación web desarrollada con **ASP.NET Core** que simula una tienda online de una carnicería.  
Incluye un **frontend en HTML, CSS y JavaScript** y un **backend en ASP.NET** con una **base de datos SQLite que se crea automáticamente al arrancar la aplicación**.

---

## 📌 Características principales

- 🛒 Interfaz web para visualizar productos y añadirlos a un carrito
- 💾 Inserción de productos comprados en una base de datos SQLite
- ⚙️ Backend en ASP.NET Core con API REST
- 🗄️ Base de datos **autogenerada automáticamente** (no se sube al repositorio)
- 🌐 Frontend servido desde `wwwroot`
- 🔄 Proyecto reproducible: no requiere pasos manuales de base de datos

---

## 🏗️ Estructura del proyecto


---

## 🗄️ Base de datos

- Motor: **SQLite**
- Archivo: `base_datos_pw3.db` (creado automáticamente en local)
- **NO se incluye en el repositorio**
- La tabla `productos` se crea al arrancar la aplicación mediante código C#

Estructura de la tabla:

```sql
CREATE TABLE productos (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    titulo TEXT NOT NULL,
    url_imagen TEXT NOT NULL,
    precio REAL NOT NULL
);

## 🚀 Cómo ejecutar el proyecto en local

### 📋 Requisitos

- .NET SDK **8.0** o superior  
- Navegador web moderno (Chrome, Firefox, Edge, etc.)

---

### ▶️ Pasos para ejecutar el proyecto

#### 1️⃣ Clonar el repositorio

```bash
git clone https://github.com/walteralee/ASP.NET-Carnicer-a-Rivas.git
```

#### 2️⃣ Acceder al proyecto ASP.NET

```bash
cd src/API_RESS_WEB_ASPNET
```

#### 3️⃣ Ejecutar la aplicación

```bash
dotnet run
```

#### 4️⃣ Abrir la aplicación en el navegador

```bash
http://localhost:5238/
```









