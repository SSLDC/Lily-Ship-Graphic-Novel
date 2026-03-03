# Sistema de Diálogos Narrativos

Este módulo implementa un sistema de diálogos utilizado en distintas escenas narrativas del juego.

El sistema gestiona secuencias de texto, cambios dinámicos de sprite, activación de elementos UI y transiciones automáticas entre escenas.

Demuestra control de flujo, gestión de estados secuenciales y sincronización entre narrativa y presentación visual.

---

## Arquitectura General

Las clases `TextoPer`, `TextoPer1`, `TextoPer3`, `TextoPer4`, `TextoPer5`, `TextoPer6`, `TextoPer7` representan variaciones específicas del mismo sistema base, adaptadas a distintas escenas narrativas.

Cada controlador gestiona:

- Secuencias de texto mediante arrays (`string[] textos`)
- Cambios dinámicos de sprites (`Sprite[] imagenes`)
- Activación/desactivación de elementos UI
- Control de avance mediante input de teclado
- Transición automática a nueva escena al finalizar el diálogo

---

## Flujo de Funcionamiento

1. Inicialización de referencias UI (`TextMeshProUGUI`, `Image`, `GameObject`)
2. Activación diferida del cuadro de diálogo mediante `Invoke`
3. Control de avance mediante detección de `KeyCode.Return`
4. Actualización secuencial del texto
5. Cambio dinámico de sprite según condiciones narrativas
6. Transición asincrónica de escena mediante coroutine

---

## Gestión Visual

El sistema permite:

- Cambiar expresiones del personaje según el punto del diálogo
- Activar indicadores visuales (teclas, información contextual)
- Mostrar u ocultar elementos según progreso narrativo
- Sincronizar texto e imagen dinámicamente

---

## Conceptos Técnicos Demostrados

- Control secuencial basado en índices
- Gestión de estados narrativos
- Validación condicional en tiempo de ejecución
- Programación orientada a eventos (input)
- Ejecución asincrónica mediante coroutines
- Comunicación entre sistemas desacoplados (Transición de escena)
- Gestión dinámica de interfaz en runtime

---

## Enfoque Arquitectónico

Aunque existen múltiples clases, todas siguen una estructura común:

- Separación entre lógica narrativa y transición de escena
- Modularidad por escena
- Control explícito del flujo de ejecución
- Sincronización entre narrativa y presentación visual

Este sistema demuestra capacidad para diseñar controladores narrativos estructurados, manejar estados secuenciales y coordinar múltiples elementos UI dentro de un flujo interactivo.