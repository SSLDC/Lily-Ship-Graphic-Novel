# Sistema de Enemigos y Gestión de Nivel

Este módulo implementa el sistema principal de generación de enemigos, control de puntuación, gestión de victoria/derrota y lógica de pausa del juego.

Demuestra control de flujo, manejo de estados globales y coordinación entre múltiples sistemas del juego (jugador, enemigos, UI y spawner).

---

## Movimiento y Comportamiento de Enemigos

### MovimientoEnemigo.cs

Controla el desplazamiento, daño y destrucción de cada enemigo.

### Responsabilidades principales:

- Movimiento continuo en eje Z
- Detección de colisiones con jugador y proyectiles
- Gestión de vida del enemigo
- Instanciación de efectos visuales (explosión)
- Comunicación con el sistema de puntuación
- Feedback visual al recibir daño (cambio de color temporal)

### Conceptos demostrados:

- Uso de `OnTriggerEnter` para detección de colisiones
- Gestión de vida y destrucción controlada
- Uso de coroutines para efectos temporales
- Comunicación entre sistemas (enemigo → generador → puntuación)
- Prevención de destrucción duplicada mediante flags

---

## Generación de Enemigos y Control del Nivel

### GenerarEnemigos.cs

Clase central que controla la lógica del nivel.

Gestiona:

- Spawning dinámico de enemigos
- Sistema de puntuación
- Condición de victoria y derrota
- Sistema de pausa
- UI de estado (ganar / perder)
- Desbloqueo progresivo de niveles

---

## Sistema de Spawning

- Generación aleatoria de enemigos
- Posiciones aleatorias dentro de límites definidos
- Uso de `InvokeRepeating` para aparición periódica
- Cancelación del spawn al finalizar el nivel

---

## Sistema de Progreso

- Incremento de puntos al destruir enemigos
- Comparación contra puntos necesarios para ganar
- Activación automática de estado de victoria
- Desbloqueo progresivo de niveles mediante variables estáticas

---

## Sistema de Pausa

- Control mediante tecla `Escape`
- Uso de `Time.timeScale`
- Animación previa a la pausa
- Activación/desactivación de botones UI
- Bloqueo de disparo del jugador durante pausa

Demuestra gestión coordinada entre animaciones, tiempo del juego y estado global.

---

## Sistema Visual Dinámico

Incluye cambios dinámicos de imagen según estado de vida:

- Cambio de sprite según porcentaje de vida
- Modificación de escala y posición UI
- Efectos visuales temporales con coroutines
- Cancelación automática de generación al morir

---

## Conceptos Técnicos Aplicados

- Control centralizado del estado del nivel
- Comunicación entre múltiples componentes
- Gestión de eventos de entrada
- Uso de variables estáticas para progresión global
- Control de flujo basado en condiciones
- Ejecución asincrónica mediante coroutines
- Manejo de UI en tiempo real

---

## Qué demuestra este módulo

Este sistema refleja la capacidad de:

- Diseñar lógica completa de un nivel
- Coordinar múltiples sistemas simultáneamente
- Gestionar estados globales (pausa, victoria, derrota)
- Implementar progresión y desbloqueo
- Controlar el flujo del juego de forma estructurada

Es una implementación funcional de un sistema de nivel completo, integrando enemigos, jugador, puntuación y UI en un flujo coherente.