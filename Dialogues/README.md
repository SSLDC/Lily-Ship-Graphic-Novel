# Narrative Dialogue System

## English

This module implements a dialogue system used across different narrative scenes of the game.

The system manages text sequences, dynamic sprite changes, UI element activation, and automatic scene transitions.

It demonstrates flow control, sequential state management, and synchronization between narrative logic and visual presentation.

---

## General Architecture

The classes `TextoPer`, `TextoPer1`, `TextoPer3`, `TextoPer4`, `TextoPer5`, `TextoPer6`, and `TextoPer7` represent specialized variations of the same base system, adapted to different narrative scenes.

Each controller manages:

- Text sequences using arrays (`string[] textos`)  
- Dynamic sprite switching (`Sprite[] imagenes`)  
- UI element activation and deactivation  
- Progression control through keyboard input  
- Automatic scene transition at dialogue completion  

---

## Execution Flow

1. Initialize UI references (`TextMeshProUGUI`, `Image`, `GameObject`)  
2. Deferred dialogue box activation using `Invoke`  
3. Progression control using `KeyCode.Return` input detection  
4. Sequential text updating  
5. Character expression changes based on narrative state  
6. Asynchronous scene transition using coroutines  

---

## Visual Management

The system supports:

- Character expression changes depending on dialogue context  
- Visual indicators (keys, contextual hints)  
- Dynamic visibility of UI elements  
- Runtime synchronization of text and images  

---

## Technical Concepts Demonstrated

- Index-based sequential control  
- Narrative state management  
- Runtime conditional validation  
- Event-driven programming (input handling)  
- Asynchronous execution using coroutines  
- Decoupled system communication (scene transitions)  
- Dynamic UI runtime management  

---

## Architectural Approach

Although multiple classes exist, they follow a shared structural pattern:

- Separation between narrative logic and scene transition control  
- Scene-based modularity  
- Explicit execution flow management  
- Synchronization between narrative and visual presentation  

This system demonstrates the ability to design structured narrative controllers, manage sequential states, and coordinate multiple UI components within an interactive flow.

---

## Español

# Sistema de Diálogos Narrativos

Este módulo implementa un sistema de diálogos utilizado en distintas escenas narrativas del juego.

El sistema gestiona secuencias de texto, cambios dinámicos de sprites, activación de elementos de interfaz y transiciones automáticas entre escenas.

Demuestra control de flujo, gestión de estados secuenciales y sincronización entre narrativa y presentación visual.

---

## Arquitectura General

Las clases `TextoPer`, `TextoPer1`, `TextoPer3`, `TextoPer4`, `TextoPer5`, `TextoPer6` y `TextoPer7` representan variaciones especializadas del mismo sistema base, adaptadas a distintas escenas narrativas.

Cada controlador gestiona:

- Secuencias de texto mediante arrays (`string[] textos`)  
- Cambio dinámico de sprites (`Sprite[] imagenes`)  
- Activación y desactivación de elementos de la interfaz  
- Control de avance mediante entrada de teclado  
- Transición automática de escena al finalizar el diálogo  

---

## Flujo de Ejecución

1. Inicialización de referencias de interfaz (`TextMeshProUGUI`, `Image`, `GameObject`)  
2. Activación diferida del cuadro de diálogo mediante `Invoke`  
3. Control de progreso mediante detección de `KeyCode.Return`  
4. Actualización secuencial del texto  
5. Cambio de expresión del personaje según el estado narrativo  
6. Transición de escena asincrónica mediante coroutines  

---

## Gestión Visual

El sistema permite:

- Cambiar expresiones del personaje según el contexto del diálogo  
- Mostrar indicadores visuales (teclas, ayudas contextuales)  
- Controlar la visibilidad de elementos de la interfaz  
- Sincronizar texto e imagen en tiempo de ejecución  

---

## Conceptos Técnicos Demostrados

- Control secuencial basado en índices  
- Gestión de estados narrativos  
- Validación condicional en runtime  
- Programación orientada a eventos  
- Ejecución asincrónica mediante coroutines  
- Comunicación entre sistemas desacoplados  
- Gestión dinámica de la interfaz  

---

## Enfoque Arquitectónico

Aunque existen múltiples clases, todas siguen un patrón estructural común:

- Separación entre lógica narrativa y control de transición de escenas  
- Modularidad por escena  
- Control explícito del flujo de ejecución  
- Sincronización entre narrativa y presentación visual  

Este sistema demuestra capacidad para diseñar controladores narrativos estructurados, gestionar estados secuenciales y coordinar múltiples componentes de interfaz dentro de un flujo interactivo.
