# Scene Controllers and Multimedia Management

## English

This module centralizes scene lifecycle management, persistent object control, audio handling, and event-based multimedia transitions.

It demonstrates event-oriented programming, singleton instance management, context-based scene logic, and dynamic resource control during runtime.

---

## Audio Management and Scene Lifecycle

### MusicaGame.cs

**Main Responsibilities:**
- Maintain a single global instance across scenes  
- Subscribe to `SceneManager.sceneLoaded` events  
- Dynamically validate existence based on the current scene  
- Automatically destroy duplicate instances  
- Safe event subscription and unsubscription  

**Demonstrated Concepts:**
- Lifecycle control using Singleton pattern  
- Context-based conditional validation  
- Controlled runtime self-destruction  
- Safe event management  

---

### ControladorMusica.cs

**Main Responsibilities:**
- Maintain a persistent `AudioSource` between scenes  
- Dynamically evaluate whether music should play  
- Play, pause, or restart audio based on system state  
- Prevent duplicate audio instances  

**Demonstrated Concepts:**
- Resource lifecycle management  
- State-based conditional execution  
- Dynamic playback control  
- Separation of responsibilities  

---

## Video-Based Scene Transitions

### ControladorVideo.cs

**Main Responsibilities:**
- Subscribe to the `loopPointReached` event from `VideoPlayer`  
- Trigger transitions using coroutines  
- Enable communication between decoupled components  

**Demonstrated Concepts:**
- Event-driven programming  
- Asynchronous execution using coroutines  
- Cross-system communication  
- Automated narrative flow control  

---

## Level State Controller (UI)

### ControladorNiveles.cs

**Main Responsibilities:**
- Enable or disable UI buttons based on progression state  
- Read global state variables  
- Control UI visibility dynamically  
- Apply conditional unlock logic  
- Execute delayed actions using `Invoke`  

**Demonstrated Concepts:**
- Runtime UI state management  
- Synchronization with progression systems  
- Conditional flow control  
- Deferred execution  

---

## Design Patterns and Development Approach

- Lifecycle management using Singleton pattern  
- Event-driven architecture  
- Runtime conditional validation  
- Scene-system synchronization  
- Separation of responsibilities  
- Asynchronous control using coroutines  

---

## Español

## Controladores de Escena y Gestión Multimedia

Este módulo centraliza la gestión del ciclo de vida de escenas, control de objetos persistentes, manejo de audio y transiciones multimedia basadas en eventos.

Demuestra programación orientada a eventos, uso del patrón Singleton, lógica condicional dependiente del contexto de escena y control dinámico de recursos en tiempo de ejecución.

---

## Gestión de Audio y Ciclo de Escena

### MusicaGame.cs

**Funciones principales:**
- Mantener una única instancia global entre escenas  
- Suscribirse al evento `SceneManager.sceneLoaded`  
- Validar dinámicamente la existencia del objeto según la escena actual  
- Eliminar automáticamente instancias duplicadas  
- Gestionar suscripciones y desuscripciones de eventos de forma segura  

**Conceptos demostrados:**
- Control del ciclo de vida mediante Singleton  
- Validación condicional basada en contexto  
- Autodestrucción controlada en runtime  
- Gestión segura de eventos  

---

### ControladorMusica.cs

**Funciones principales:**
- Mantener un `AudioSource` persistente entre escenas  
- Evaluar dinámicamente si la música debe reproducirse  
- Reproducir, pausar o reiniciar el audio según el estado del sistema  
- Evitar la creación de instancias duplicadas  

**Conceptos demostrados:**
- Gestión del ciclo de vida de recursos  
- Ejecución condicional basada en estado  
- Control dinámico de reproducción  
- Separación de responsabilidades  

---

## Transiciones de Escena Basadas en Video

### ControladorVideo.cs

**Funciones principales:**
- Suscribirse al evento `loopPointReached` del `VideoPlayer`  
- Activar transiciones mediante coroutines  
- Permitir comunicación entre componentes desacoplados  

**Conceptos demostrados:**
- Programación orientada a eventos  
- Ejecución asincrónica con coroutines  
- Comunicación entre sistemas  
- Control automático del flujo narrativo  

---

## Controlador de Estado de Niveles (UI)

### ControladorNiveles.cs

**Funciones principales:**
- Activar o desactivar botones según el progreso  
- Leer variables de estado global  
- Controlar la visibilidad de elementos de la interfaz  
- Aplicar lógica condicional de desbloqueo  
- Ejecutar acciones con retraso controlado mediante `Invoke`  

**Conceptos demostrados:**
- Gestión de UI en tiempo de ejecución  
- Sincronización con sistemas de progresión  
- Control de flujo condicional  
- Ejecución diferida de procesos  

---

## Patrones y Enfoque de Desarrollo

- Gestión del ciclo de vida mediante Singleton  
- Arquitectura orientada a eventos  
- Validación condicional en runtime  
- Sincronización entre escenas y sistemas  
- Separación de responsabilidades  
- Control asincrónico mediante coroutines  
