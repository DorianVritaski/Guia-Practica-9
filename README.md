Nombre del Estudio
Estudio de Desarrollo "Neurobyte"

Miembros y Roles
- Tapia De La Cruz Jhann Pier 1 – Arquitecto de IA
- Calderon Huamán Jerico Owen 2 – Diseñador/a de Comportamiento

Descripción del Hito
En esta práctica 12 implementamos un sistema de inteligencia artificial basado en el Patrón de Diseño State, integrando tres estados principales: patrulla, persecución y aturdimiento (StunState). 
El enemigo patrulla entre puntos definidos, detecta al jugador dentro de un radio configurable, lo persigue, y puede ser aturdido mediante una interacción simulada con un "Rifle". 
El estado de aturdimiento detiene al agente temporalmente y luego lo devuelve al patrullaje, todo gestionado con corrutinas y transiciones limpias entre estados.

Reflexión del Estudio
- Sinergia y Fricción: ¿Cuál fue el mayor beneficio de trabajar en equipo para esta tarea? ¿Y cuál fue el mayor desafío de comunicación o coordinación que enfrentaron y cómo lo resolvieron?

El mayor beneficio de trabajar en equipo fue la especialización, cada miembro pudo enfocarse en su rol, lo que aceleró el desarrollo y permitió una implementación. El Arquitecto se centró en la lógica de estados, 
el Diseñador ajustó los parámetros para lograr una IA convincente, y el Integrador garantizó que todo funcionara en el entorno del juego. El mayor desafío fue coordinar los tiempos de prueba y ajuste, especialmente 
cuando los cambios en los estados afectaban la configuración del NavMesh o los prefabs. Lo resolvimos estableciendo checkpoints de integración y comunicación constante por mensajes breves y claros.

- El Alma de la Máquina:Más allá del código, ¿qué parámetro ([SerializeField]) descubrieron que tenía el mayor impacto en hacer que la IA se sintiera más "viva" o "inteligente"? (Ejemplo: detectionRadius, chaseSpeed,
la diferencia entre detectionRadius y loseSightRadius, etc.)

El parámetro que más impacto tuvo en hacer que la IA se sintiera "viva" fue la diferencia entre detectionRadius y loseSightRadius. Esta diferencia permitió que el enemigo tuviera un comportamiento más humano, detectaba al jugador con rapidez, 
pero no lo perdía de inmediato al alejarse, lo que generaba una sensación de persistencia e intención. Ajustar estos valores fue clave para lograr una IA que no solo reaccionara, sino que pareciera pensar.
