# Enemy System and Level Management

## English

This module implements the main enemy generation system, score control, victory/defeat state handling, and game pause logic.

It demonstrates flow control, global state management, and coordination between multiple game subsystems including player, enemies, UI, and spawner logic.

---

## Enemy Movement and Behavior

### MovimientoEnemigo.cs

Controls enemy movement, damage handling, and destruction logic.

### Main Responsibilities

- Continuous movement along the Z-axis  
- Collision detection with player and projectiles  
- Enemy health management  
- Visual effect instantiation (explosion effects)  
- Communication with scoring system  
- Damage feedback visualization (temporary color change)

### Technical Concepts Demonstrated

- Use of `OnTriggerEnter` for collision detection  
- Controlled lifecycle destruction management  
- Coroutine-based temporal effects  
- Cross-system communication (enemy → spawner → scoring system)  
- Prevention of duplicate destruction using state flags  

---

## Enemy Generation and Level Control

### GenerarEnemigos.cs

Central class responsible for level logic management.

Handles:

- Dynamic enemy spawning  
- Score tracking system  
- Victory and defeat conditions  
- Pause system control  
- State UI management (win/loss screens)  
- Progressive level unlocking  

---

## Spawning System

- Random enemy generation  
- Spawn positions constrained within predefined boundaries  
- Use of `InvokeRepeating` for periodic spawning  
- Spawn cancellation when level ends  

---

## Progression System

- Score increment when enemies are destroyed  
- Comparison against required victory score  
- Automatic victory state activation  
- Global progression unlocking using static variables  

---

## Pause System

- Pause control using `Escape` key input  
- Time control using `Time.timeScale`  
- Pre-pause animation handling  
- UI button activation/deactivation  
- Player shooting lock during pause state  

This demonstrates coordinated management between animations, game time, and global state.

---

## Dynamic Visual Feedback

Includes dynamic image changes based on health state:

- Sprite changes according to health percentage  
- UI scale and position adjustments  
- Temporary visual effects using coroutines  
- Automatic spawning cancellation upon enemy or player death  

---

## Applied Technical Concepts

- Centralized level state management  
- Multi-component system communication  
- Input event handling  
- Global progression tracking using static variables  
- Condition-based flow control  
- Asynchronous execution using coroutines  
- Real-time UI management  

---

## What This Module Demonstrates

This system reflects the ability to:

- Design complete level gameplay logic  
- Coordinate multiple systems simultaneously  
- Manage global game states (pause, victory, defeat)  
- Implement progression and unlock mechanics  
- Control game flow in a structured manner  

This is a functional implementation of a full level system integrating enemies, player interaction, scoring, and UI into a coherent gameplay pipeline.

---

## Español

# Sistema de Enemigos y Gestión de Nivel

Este módulo implementa el sistema principal de generación de enemigos, control de puntuación, gestión de estados de victoria/derrota y lógica de pausa del juego.

Demuestra control de flujo, gestión de estados globales y coordinación entre múltiples subsistemas del juego, incluyendo jugador, enemigos, interfaz y spawner.

---

## Movimiento y Comportamiento de Enemigos

### MovimientoEnemigo.cs

Controla el movimiento, daño y destrucción de cada enemigo.

### Responsabilidades Principales

- Movimiento continuo en el eje Z  
- Detección de colisiones con jugador y proyectiles  
- Gestión de vida del enemigo  
- Instanciación de efectos visuales (explosión)  
- Comunicación con el sistema de puntuación  
- Retroalimentación visual al recibir daño (cambio temporal de color)

---

## Generación de Enemigos y Control de Nivel

### GenerarEnemigos.cs

Clase central encargada de la lógica del nivel.

Gestiona:

- Aparición dinámica de enemigos  
- Sistema de puntuación  
- Condiciones de victoria y derrota  
- Control de pausa  
- Estado de la interfaz (ganar / perder)  
- Desbloqueo progresivo de niveles  

---

## Sistema de Spawn

- Generación aleatoria de enemigos  
- Límites espaciales de aparición  
- Uso de `InvokeRepeating` para generación periódica  
- Cancelación de spawn al finalizar el nivel  

---

## Sistema de Progresión

- Incremento de puntuación al destruir enemigos  
- Comparación con puntuación requerida para ganar  
- Activación automática del estado de victoria  
- Progresión global mediante variables estáticas  

---

## Sistema de Pausa

- Control mediante tecla `Escape`  
- Gestión del tiempo usando `Time.timeScale`  
- Animación previa a la pausa  
- Activación y desactivación de elementos UI  
- Bloqueo de disparos del jugador durante la pausa  

Demuestra coordinación entre animaciones, control de tiempo y estado global del juego.

---

## Conceptos Técnicos Aplicados

- Gestión centralizada del estado del nivel  
- Comunicación entre múltiples componentes  
- Manejo de eventos de entrada  
- Uso de variables estáticas para progresión global  
- Control de flujo basado en condiciones  
- Ejecución asincrónica mediante coroutines  
- Gestión de interfaz en tiempo real  

---

## Qué demuestra este módulo

Este sistema refleja la capacidad de:

- Diseñar lógica completa de un nivel jugable  
- Coordinar múltiples sistemas simultáneamente  
- Gestionar estados globales (pausa, victoria, derrota)  
- Implementar progresión y mecánicas de desbloqueo  
- Controlar el flujo del juego de forma estructurada  
