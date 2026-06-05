# Sistema de Gestión de Pólizas de Seguros

**Asignatura:** Programación en C# (`cs-`)

---

Aplicación de escritorio desarrollada en C# con Windows Forms para la administración de clientes y control de pólizas aseguradoras con almacenamiento temporal en memoria.

## Arquitectura del Sistema

El sistema está implementado bajo un esquema de acoplamiento directo entre la interfaz gráfica y las estructuras de datos, utilizando principios de Programación Orientada a Objetos (POO) para la vinculación relacional de entidades:

* **Colaboración de Clases:** Implementación de relaciones lógicas entre componentes, donde la entidad `Poliza.cs` incorpora la estructura de la clase `Cliente.cs` para asociar de manera directa y unificada un contrato de seguro con su titular correspondiente.
* **Estructura de Datos en Memoria:** El almacenamiento global de los registros consolidados se administra mediante una colección dinámica de tipo `ArrayList`, lo que permite la indexación, consulta y despliegue tabular continuo de la información sin restricciones de tamaño fijo.
* **Punto de Entrada e Interfaz:** Inicialización del entorno gráfico mediante `Program.cs`, el cual despliega el contenedor principal (`FrmGestionSeguros.cs`). Las operaciones del negocio se aíslan en componentes modulares *User Controls* (`UC_`) para los flujos específicos de agregación, consulta, simulación financiera y reportería general.
