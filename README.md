# File Organizer

File Organizer es una aplicación de escritorio desarrollada en **VB.NET** utilizando **Windows Forms** y **LiveCharts** para organizar automáticamente archivos en una carpeta, clasificándolos por tipo y generando gráficos estadísticos sobre su distribución.

## 📌 Características Principales

✅ **Selección de Carpeta**: Permite seleccionar la carpeta a organizar.
✅ **Clasificación Automática**: Ordena archivos en subcarpetas según su tipo.
✅ **Barra de Progreso**: Indica el estado de la organización.
✅ **Gráfico de Distribución**: Usa **LiveCharts** para mostrar el porcentaje de archivos por tipo.
✅ **Opciones Avanzadas**: Permite eliminar duplicados.
✅ **Historial de Eventos**: Guarda un registro de operaciones en un log.
✅ **Interfaz Personalizable**: Compatible con temas oscuros y claros.

---

## 🛠️ Instalación y Requisitos

### **🔧 Requisitos Previos**
- **Sistema Operativo**: Windows 10 o superior.
- **Framework**: .NET Framework 4.8.
- **Dependencias**:
  - [LiveCharts](https://lvcharts.net/)
  - MaterialSkin2 para Windows Forms.

### **📥 Instalación**
1. Clonar este repositorio:
   ```sh
   git clone https://github.com/rmalanco/FileOrganizer.git
   ```
2. Abrir el proyecto en **Visual Studio**.
3. Restaurar paquetes NuGet:
   ```sh
   Install-Package LiveCharts
   Install-Package MaterialSkin2
   ```
4. Compilar y ejecutar.

---

## 🚀 Uso

1. **Seleccionar una carpeta** con el botón "Buscar Carpeta".
2. Presionar "Organizar Archivos" para iniciar el proceso.
3. Revisar el gráfico de distribución y los registros en el log.

---

## 📊 Gráfica de Distribución

- Usa **LiveCharts** para representar visualmente el porcentaje de archivos.
- Muestra el **nombre de la extensión y su porcentaje** al pasar el mouse sobre un sector del gráfico.

---

## 📂 Estructura del Proyecto

```
📂 FileOrganizer
 ┣ 📂 FileOrganizer.Common        # Módulos compartidos
 ┣ 📂 FileOrganizer.Domain        # Lógica de negocio
 ┣ 📂 FileOrganizer.Presentation  # Interfaz gráfica (Windows Forms)
 ┣ 📂 FileOrganizer.Logs          # Carpeta para registros de logs
 ┣ 📜 README.md                   # Documentación del proyecto
 ┣ 📜 FileOrganizer.sln           # Solución de Visual Studio
```

---

## 📄 Licencia
Este proyecto está bajo la **Licencia MIT** – consulta el archivo `LICENSE` para más detalles.

---

## 📞 Contacto y Soporte
Para reportar errores o contribuir al proyecto, contacta a:
📧 Email: rmalanco@rmalanco.com  
🐙 GitHub: [github.com/RMalanco](https://github.com/RMalanco)
