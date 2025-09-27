# Repaso-PC1-Fundamentos-Sistemas: Sistema de Gestión de Almacenes

Aplicación desarrollada en **C# con Windows Forms** para el empadronamiento de almacenes ubicados en el **Puerto de Chancay**, que permite registrar sus servicios y generar reportes.

---

## 🗂️ Entidades del Sistema

### Almacén
- Código (único)
- Nombre
- Tipo (Insumos, Productos terminados, Tránsito, Distribución)
- Capacidad en kg

### Servicio
- Código (único)
- Nombre
- Categoría (Nacional, Internacional)
- Costo

---

## ✅ Checklist de Funcionalidades

- [x] **Clases definidas correctamente** (`Almacen`, `Servicio`) **(2 pts)**
- [ ] **Registrar y mostrar almacenes**  
  - Uso de `ComboBox` para seleccionar el **tipo de almacén**. **(3 pts)**
- [ ] **Registrar y mostrar servicios de un almacén**  
  - Uso de `ComboBox` para seleccionar la **categoría del servicio**. **(4 pts)**
- [x] **Validación de códigos únicos**  
  - Tanto en almacenes como en servicios. **(2 pts)**
- [x] **Asignar múltiples servicios a un almacén**  
  - Sin permitir duplicados. **(3 pts)**
- [x] **Reporte: Almacenes por tipo**  
  - Ingresa un tipo → devuelve lista de almacenes del mismo tipo. **(3 pts)**
- [x] **Reporte: Almacenes sin servicios registrados** **(3 pts)**
