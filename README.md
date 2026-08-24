# VitaStays — Proyecto IDS

Sistema de gestión para un complejo de cabañas desarrollado como aplicación de escritorio en **C# y .NET 8**, utilizando **Windows Forms**, **Entity Framework Core** y **SQL Server**.

El proyecto permite administrar las principales operaciones de un alojamiento: cabañas, clientes, reservas, usuarios, empleados, servicios y mantenimientos. Además, incorpora control de permisos, auditoría de acciones y manejo de estados para reservas y asignaciones.

## Funcionalidades principales

- Gestión de **cabañas**, incluyendo imágenes, disponibilidad y desactivación temporal.
- Gestión de **clientes**.
- Gestión de **reservas** con validación de fechas y disponibilidad.
- Estados automáticos de reservas: pendiente, activa, finalizada y cancelada.
- Registro de **motivos de cancelación**.
- Gestión de **servicios adicionales** y sus categorías.
- Asignación de servicios a reservas.
- Gestión de **mantenimientos**.
- Asignación de mantenimientos a cabañas y empleados.
- Posibilidad de desactivar una cabaña durante un mantenimiento.
- Gestión de **empleados**, roles y turnos.
- Gestión de **usuarios, grupos y permisos**.
- Control de acceso a funcionalidades según permisos.
- **Auditoría** de accesos y operaciones sobre clientes.
- Recuperación de contraseña mediante correo electrónico con **SendGrid**.
- Informes sobre información del sistema, incluyendo motivos de cancelación.

## Arquitectura

La solución está organizada en distintas capas para separar responsabilidades:

```text
ProyectoIDS/
│
├── VISTA/          # Interfaz gráfica Windows Forms
├── CONTROLADORA/   # Lógica de negocio y coordinación
├── MODELO/         # Entidades, acceso a datos y Entity Framework Core
├── CAPA COMUN/     # Elementos compartidos, caché y contratos comunes
└── Proyecto_IDS.sln
```

### VISTA

Contiene la interfaz gráfica de la aplicación y los formularios correspondientes a:

- inicio de sesión;
- administración de cabañas;
- clientes;
- usuarios;
- empleados;
- reservas;
- servicios;
- mantenimientos;
- permisos y grupos;
- auditoría;
- informes;
- configuración del usuario.

### CONTROLADORA

Centraliza la lógica de negocio y actúa como intermediaria entre la interfaz y el modelo de datos.

Incluye controladoras específicas para reservas, usuarios, clientes, empleados, cabañas, servicios, mantenimientos, permisos, grupos, auditoría e informes.

### MODELO

Contiene las entidades de dominio y la configuración de **Entity Framework Core** para persistir los datos en SQL Server.

Entre las principales entidades se encuentran:

- `Usuario`
- `Cliente`
- `Cabaña`
- `Reserva`
- `Empleado`
- `Servicio`
- `Mantenimiento`
- `AsignacionServicio`
- `AsignacionMantenimiento`
- `Grupo`
- `Permiso`

### CAPA COMUN

Contiene componentes compartidos entre las distintas capas, como información del usuario autenticado y contratos utilizados por el sistema.

## Patrones y conceptos aplicados

El proyecto implementa distintos conceptos de diseño y arquitectura, entre ellos:

- **Arquitectura por capas**.
- **Singleton** en distintas controladoras de negocio.
- **State Pattern** para representar y actualizar los estados de reservas, servicios asignados y mantenimientos asignados.
- **Composite / estructura de grupos y permisos** para el control de acceso.
- Separación entre interfaz, lógica de negocio y persistencia.
- Uso de relaciones uno-a-muchos y muchos-a-muchos mediante Entity Framework Core.

## Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| C# | Lenguaje principal |
| .NET 8 | Plataforma de desarrollo |
| Windows Forms | Interfaz gráfica de escritorio |
| Entity Framework Core | ORM y acceso a datos |
| SQL Server | Base de datos relacional |
| SendGrid | Recuperación de contraseña por correo |
| DotNetEnv | Variables de entorno |
| SHA-256 | Hash utilizado por el proyecto para contraseñas |
| ClosedXML / OpenXML | Soporte para documentos y planillas |
| iTextSharp | Soporte para generación de documentos PDF |

## Requisitos

Para ejecutar el proyecto se recomienda contar con:

- **Windows 10 u 11**.
- **Visual Studio 2022**.
- Workload **Desarrollo de escritorio con .NET**.
- **.NET 8 SDK**.
- **SQL Server** o **SQL Server Express**.
- SQL Server Management Studio, opcional pero recomendado.

## Configuración de la base de datos

La conexión se encuentra actualmente definida en:

```text
MODELO/Context.cs
```

Dentro de la clase `Context` se utiliza una cadena de conexión de SQL Server. Para ejecutar el proyecto en otra computadora es necesario modificarla para que apunte a la instancia local de SQL Server.

Ejemplo:

```csharp
Data Source=.\SQLEXPRESS;
Initial Catalog=Sistema_IDS;
Integrated Security=True;
Encrypt=False;
```

> La cadena anterior es solamente un ejemplo. Debe adaptarse a la instancia de SQL Server disponible en cada equipo.

La base utilizada por el proyecto se denomina:

```text
Sistema_IDS
```

El proyecto incluye migraciones de Entity Framework Core dentro de `MODELO/Migrations`.

## Configuración de SendGrid

La aplicación utiliza SendGrid para el proceso de recuperación de contraseña.

Dentro de `VISTA` existe el archivo:

```text
.env.ejemplo
```

Crear una copia llamada:

```text
.env
```

Y completar las variables:

```env
SENDGRID_API_KEY=TU_API_KEY_DE_SENDGRID
SENDGRID_EMAIL=correo_remitente@dominio.com
SENDGRID_NAME=VitaStays Soporte
```

El archivo `.env` está excluido mediante `.gitignore` y **no debe subirse al repositorio**.

## Ejecución

### Desde Visual Studio

1. Abrir:

```text
Proyecto_IDS.sln
```

2. Verificar la conexión con SQL Server.
3. Configurar el archivo `.env` si se utilizará la recuperación de contraseña.
4. Establecer `VISTA` como proyecto de inicio.
5. Ejecutar la solución.

### Desde terminal

Restaurar dependencias:

```bash
dotnet restore Proyecto_IDS.sln
```

Compilar:

```bash
dotnet build Proyecto_IDS.sln
```

Ejecutar la aplicación:

```bash
dotnet run --project VISTA/VISTA.csproj
```

> Al tratarse de una aplicación Windows Forms, debe ejecutarse en Windows.

## Seguridad

El sistema incorpora:

- autenticación de usuarios;
- contraseñas procesadas mediante SHA-256;
- grupos y permisos;
- control de acceso a distintas pantallas;
- auditoría de inicio de sesión y operaciones;
- recuperación de contraseña mediante correo electrónico;
- exclusión del archivo `.env` del control de versiones.

Para un entorno productivo se recomienda reemplazar el esquema de hash de contraseñas por un algoritmo específicamente diseñado para contraseñas, como **BCrypt, Argon2 o PBKDF2**.

## Estado del proyecto

Proyecto académico funcional desarrollado para aplicar conceptos de:

- ingeniería de software;
- arquitectura por capas;
- programación orientada a objetos;
- patrones de diseño;
- persistencia de datos;
- seguridad y permisos;
- gestión de operaciones de un sistema real.

## Repositorio

GitHub:

```text
https://github.com/Ignaco1/ProyectoIDS
```
