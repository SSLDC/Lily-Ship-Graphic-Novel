# Controladores de Escena y Gestión Multimedia

Este módulo centraliza la gestión del ciclo de vida de escenas, objetos persistentes, control de audio y transiciones basadas en eventos multimedia.

Demuestra programación orientada a eventos, gestión de instancias únicas (Singleton), lógica condicional basada en escenas y control dinámico de recursos en tiempo de ejecución.

---

## Gestión de Audio y Ciclo de Escena

### MusicaGame.cs

**Acciones principales:**
- Garantizar una única instancia global entre escenas  
- Suscribirse al evento `SceneManager.sceneLoaded`  
- Validar dinámicamente si debe existir según la escena actual  
- Destruir duplicados automáticamente  
- Gestión correcta de suscripción y desuscripción de eventos  

**Conceptos demostrados:**
- Control de ciclo de vida mediante Singleton  
- Validación condicional basada en contexto de escena  
- Autodestrucción controlada en runtime  
- Gestión segura de eventos  

---

### ControladorMusica.cs

**Acciones principales:**
- Mantener un `AudioSource` persistente entre escenas  
- Evaluar dinámicamente si la música debe reproducirse  
- Reproducir, pausar o reiniciar el audio según el estado  
- Evitar instancias duplicadas  

**Conceptos demostrados:**
- Gestión del ciclo de vida de recursos  
- Ejecución condicional basada en estado  
- Control dinámico de reproducción  
- Separación de responsabilidades  

---

## Transiciones de Escena Basadas en Video

### ControladorVideo.cs

**Acciones principales:**
- Suscripción al evento `loopPointReached` del `VideoPlayer`  
- Activación de transición mediante coroutine  
- Comunicación entre componentes desacoplados  

**Conceptos demostrados:**
- Programación orientada a eventos  
- Ejecución asincrónica mediante coroutines  
- Comunicación entre sistemas  
- Control automatizado de flujo narrativo  

---

## Controlador de Estado de Niveles (UI)

### ControladorNiveles.cs

**Acciones principales:**
- Activar/desactivar botones según progreso  
- Leer variables de estado global  
- Controlar visibilidad de elementos UI  
- Aplicar lógica condicional de desbloqueo  
- Ejecutar acciones con retraso controlado (`Invoke`)  

**Conceptos demostrados:**
- Gestión dinámica de interfaz en runtime  
- Sincronización con sistema de progresión  
- Control condicional de flujo  
- Ejecución diferida  

---

## Patrones y Enfoque Aplicado

- Gestión de ciclo de vida mediante Singleton  
- Arquitectura orientada a eventos  
- Validación condicional en tiempo de ejecución  
- Sincronización entre escenas y sistemas  
- Separación de responsabilidades  
- Control asincrónico con coroutines  