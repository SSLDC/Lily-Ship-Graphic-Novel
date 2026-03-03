# Visual Interface and Transition System

## English

This module implements the user interface system, menu visual design, and scene transition control.

The system manages dynamic activation of UI elements, button hover effects, and scene change animations.

---

## Message and Initial Menu Control

### NewMonoBehaviourScript.cs

Controls the progressive appearance of interface elements.

### Main Features

- Deferred activation of text and buttons  
- UI visibility management  
- Temporal synchronization using `Invoke`  

### Technical Concepts Demonstrated

- Runtime visual flow control  
- Basic UI state management  
- Controlled initialization of graphical elements  

---

## Scene Transition System

### Transicion.cs

Handles scene change animations.

### Functionalities

- Transition animation execution using Animator  
- Scene switching synchronized with timing logic  
- Game time reset before scene change  
- Transition activation through user input  

### Technical Concepts Demonstrated

- Coroutine-based asynchronous execution  
- Animation and gameplay logic synchronization  
- Runtime scene management  

---

## Interactive Button System

### BotonColor.cs

Implements interactive visual behavior for menu buttons.

### Features

- Text color change on mouse hover  
- User click detection  
- Conditional action execution based on button text  

Special behaviors:

- "Resume" option → Reactivates game pause system  
- "Close" option → Terminates application execution  
- Other options → Trigger scene transitions  

### Technical Concepts Demonstrated

- Unity event interface implementation  
- UI input handling through event-driven programming  
- Conditional flow logic  

---

## Design Approach

The system follows a component-based architecture where each class has a single primary responsibility:

- Graphical interface management  
- Transition animation control  
- User interaction handling  
- Scene flow orchestration  

---

## Español

# Sistema de Interfaz Visual y Transiciones

Este módulo implementa el sistema de interfaz de usuario, el diseño visual de menús y el control de transiciones entre escenas.

El sistema gestiona la activación dinámica de elementos de interfaz, efectos hover en botones y animaciones de cambio de escena.

---

## Control de Mensajes y Menú Inicial

### NewMonoBehaviourScript.cs

Controla la aparición progresiva de elementos de la interfaz.

### Características principales

- Activación diferida de texto y botones  
- Gestión de visibilidad de elementos UI  
- Sincronización temporal mediante `Invoke`  

### Conceptos Técnicos Demostrados

- Control de flujo visual en runtime  
- Gestión básica de estados de interfaz  
- Inicialización controlada de elementos gráficos  

---

## Sistema de Transición de Escenas

### Transicion.cs

Gestiona las animaciones de cambio de escena.

### Funcionalidades

- Ejecución de animaciones de transición mediante Animator  
- Cambio de escena sincronizado con la lógica temporal  
- Restablecimiento del tiempo del juego antes del cambio de escena  
- Activación de transición mediante entrada del usuario  

### Conceptos Técnicos Demostrados

- Ejecución asincrónica con coroutines  
- Sincronización entre animación y lógica de juego  
- Gestión de escenas en runtime  

---

## Sistema de Botones Interactivos

### BotonColor.cs

Implementa comportamiento visual interactivo para los botones del menú.

### Características

- Cambio de color del texto al pasar el cursor  
- Detección de clic del usuario  
- Ejecución condicional de acciones según el contenido del botón  

Comportamientos especiales:

- Opción "Reanudar" → Reactiva el sistema de pausa del juego  
- Opción "Cerrar" → Finaliza la ejecución de la aplicación  
- Otras opciones → Ejecutan transiciones de escena  

### Conceptos Técnicos Demostrados

- Implementación de eventos de Unity  
- Manejo de entrada mediante eventos de interfaz  
- Lógica condicional de flujo  

---

## Enfoque de Diseño

El sistema se basa en una arquitectura por componentes donde cada clase posee una responsabilidad principal:

- Gestión gráfica de la interfaz  
- Control de animaciones de transición  
- Interacción del usuario  
- Orquestación del flujo de escenas  
