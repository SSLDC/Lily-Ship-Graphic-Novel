# Sistema de Interfaz Visual y Transiciones

Este módulo implementa el sistema de interfaz de usuario, diseño visual de menús y control de transiciones entre escenas.

El sistema gestiona la activación dinámica de elementos UI, efectos de hover en botones y animaciones de cambio de escena.

---

## Control de Mensajes y Menú Inicial

### NewMonoBehaviourScript.cs

Controla la aparición progresiva de elementos de interfaz.

### Características principales:

- Activación diferida de texto y botones
- Gestión de visibilidad de elementos UI
- Uso de `Invoke` para sincronización temporal

### Conceptos técnicos demostrados:

- Control de flujo visual en runtime
- Gestión básica de estados de interfaz
- Inicialización controlada de elementos gráficos

---

## Sistema de Transición de Escenas

### Transicion.cs

Gestiona las animaciones de cambio de escena.

### Funcionalidades:

- Ejecución de animación de transición mediante Animator
- Cambio de escena con sincronización temporal
- Restablecimiento del tiempo del juego antes de cambiar de escena
- Activación de transición mediante entrada del usuario

### Conceptos demostrados:

- Programación asincrónica con coroutines
- Sincronización entre animación y lógica de juego
- Gestión de escenas en runtime

---

## Sistema de Botones Interactivos

### BotonColor.cs

Implementa comportamiento visual interactivo para los botones del menú.

### Características:

- Cambio de color del texto al pasar el cursor
- Detección de clics del usuario
- Control de acciones específicas según el texto del botón

Comportamientos especiales:

- Opción "Reanudar" → Reactiva el sistema de pausa del juego  
- Opción "Cerrar" → Finaliza la ejecución del juego o la aplicación  
- Otras opciones → Ejecutan transición de escena  

### Conceptos técnicos demostrados:

- Implementación de interfaces de eventos de Unity
- Manejo de entrada del usuario mediante eventos de UI
- Lógica condicional para control de flujo

---

## Enfoque de Diseño

El sistema está basado en una arquitectura por componentes donde cada clase tiene una responsabilidad específica:

- Gestión de interfaz gráfica
- Animaciones de transición
- Interacción del usuario
- Control del flujo de escenas
