# Player Movement, Combat and Shooting System

## English

This module implements the core gameplay mechanics for player control, shooting system, projectile behavior, and health management.

The design focuses on code organization, state control, and separation of responsibilities across different gameplay components.

---

## Player Control System

### ControlNave.cs

This class manages player movement, health state, and visual feedback when damage is received.

### Main Features

- Player movement using keyboard input  
- Visual rotation based on horizontal movement  
- Health system synchronized with UI  
- Runtime camera behavior control  
- Player death state management  

### Technical Concepts Demonstrated

- Component-based design  
- Runtime state validation  
- Cross-system communication  
- Object lifecycle management  

---

## Health System

The player health system includes:

- Maximum health tracking  
- Damage processing  
- Visual feedback when damage is taken  
- Deactivation of gameplay systems upon player death  

When health reaches zero:

- Movement is disabled  
- Particle effects are stopped  
- Shooting system is deactivated  
- Explosion effect is generated  

---

## Shooting System

### Bala.cs

Controls player shooting logic.

### Features

- Shooting rate control using time accumulation  
- Projectile generation from multiple firing points  
- Input-based shooting mechanics  
- Dynamic object instantiation in scene  

### Technical Concepts Demonstrated

- Time-based action control  
- User input handling  
- Runtime object instantiation  

---

## Projectile Behavior

### MovimientoBala.cs

Manages projectile movement and lifecycle.

Features:

- Continuous projectile movement  
- Automatic destruction after a defined time  

This helps maintain performance by preventing object accumulation.

---

## Design Approach

The system follows a component-based architecture where gameplay responsibilities are separated into independent controllers:

- Player movement and state logic  
- Combat mechanics  
- Projectile behavior  

---

## Español

# Sistema de Movimiento, Combate y Disparo del Jugador

Este módulo implementa las mecánicas principales de control del jugador, sistema de disparo, comportamiento de proyectiles y gestión de vida.

El diseño se centra en la organización del código, control de estados y separación de responsabilidades entre los diferentes componentes del gameplay.

---

## Sistema de Control del Jugador

### ControlNave.cs

Esta clase gestiona el movimiento del jugador, el estado de vida y la retroalimentación visual al recibir daño.

### Características principales

- Movimiento del jugador mediante teclado  
- Rotación visual basada en el movimiento horizontal  
- Sistema de vida sincronizado con la interfaz  
- Control de cámara en tiempo de ejecución  
- Gestión del estado de muerte del jugador  

### Conceptos Técnicos Demostrados

- Diseño basado en componentes  
- Validación de estados en runtime  
- Comunicación entre sistemas  
- Gestión del ciclo de vida de objetos  

---

## Sistema de Vida

El sistema de salud del jugador incluye:

- Seguimiento de vida máxima  
- Procesamiento de daño  
- Retroalimentación visual al recibir daño  
- Desactivación de sistemas de juego al morir  

Cuando la vida llega a cero:

- Se desactiva el movimiento  
- Se detienen los efectos de partículas  
- Se desactiva el sistema de disparo  
- Se genera un efecto de explosión  

---

## Sistema de Disparo

### Bala.cs

Controla la lógica de disparo del jugador.

### Características

- Control de velocidad de disparo mediante acumulación temporal  
- Generación de proyectiles desde múltiples puntos  
- Disparo basado en entrada del usuario  
- Instanciación dinámica de objetos en escena  

---

## Comportamiento de Proyectiles

### MovimientoBala.cs

Gestiona el movimiento y ciclo de vida de los proyectiles.

Características:

- Movimiento continuo del proyectil  
- Destrucción automática después de un tiempo  

Esto ayuda a mantener el rendimiento evitando la acumulación de objetos.

---

## Enfoque de Diseño

El sistema se basa en una arquitectura por componentes donde las responsabilidades del gameplay están separadas en controladores independientes:

- Lógica de movimiento y estado del jugador  
- Mecánicas de combate  
- Comportamiento de proyectiles  
