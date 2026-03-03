# Sistema de Movimiento, Combate y Disparo del Jugador

Este módulo implementa las mecánicas principales de control del jugador, sistema de disparo, comportamiento de proyectiles y gestión de vida.

El diseño se enfoca en la organización del código, control de estados y separación de responsabilidades entre los distintos componentes del gameplay.

---

## Sistema de Control del Jugador

### ControlNave.cs

Esta clase gestiona el movimiento del jugador, el estado de vida y el feedback visual del daño recibido.

### Características principales:

- Movimiento del jugador mediante teclado
- Rotación visual basada en el movimiento horizontal
- Sistema de vida con sincronización de UI
- Control de cámara en tiempo de ejecución
- Gestión del estado de muerte del jugador

### Conceptos técnicos demostrados:

- Diseño basado en componentes
- Validación de estados en runtime
- Comunicación entre sistemas de juego
- Control del ciclo de vida de objetos

---

## Sistema de Vida

El sistema de salud del jugador incluye:

- Seguimiento de vida máxima
- Procesamiento de daño
- Retroalimentación visual al recibir daño
- Desactivación de sistemas de juego cuando el jugador muere

Cuando la vida llega a cero:

- Se desactiva el movimiento
- Se detienen los efectos de partículas
- Se desactiva el sistema de disparo
- Se genera un efecto de explosión

---

## Sistema de Disparo

### Bala.cs

Controla la lógica de disparo del jugador.

### Características:

- Control de velocidad de disparo mediante acumulación de tiempo
- Generación de proyectiles desde múltiples puntos de disparo
- Disparo basado en entrada del usuario
- Creación dinámica de objetos en escena

### Conceptos demostrados:

- Control de acciones basado en tiempo
- Manejo de entrada del usuario
- Instanciación dinámica de objetos

---

## Comportamiento de Proyectiles

### MovimientoBala.cs

Gestiona el movimiento y ciclo de vida de los proyectiles.

Características:

- Movimiento continuo del proyectil
- Destrucción automática después de un tiempo

Esto ayuda a mantener un buen rendimiento evitando acumulación de objetos.

---

## Enfoque de Diseño

El sistema está basado en una arquitectura por componentes donde las responsabilidades del gameplay están separadas en controladores independientes:

- Lógica de movimiento y estado del jugador  
- Mecánicas de combate  
- Comportamiento de proyectiles  
