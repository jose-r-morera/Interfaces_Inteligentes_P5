# P5: Cardboard
## Descripción del juego
El jugador debe mirar a los zombies para eliminarlos, y al hacerlo, irá sumando puntos de 5 en 5.

## Notas de implementación 
- Para el patrón observador se ha empleado un evento estático, ya que los notificadores, que son los zombies, pueden ser muchos, y tener una referencia a cada uno en el suscriptor, que es un controlador, no es viable.

- Para el canvas se ha empleado un Canvas con renderizado en el espacio del mundo.

- Se ha establecido el espacio de color como Gamma para una mayor fidelidad.

- 
