using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public static float speedMoveP = 0f; // Velocidad de movimiento del jugador
    public float minX = -3.85f; // Límite mínimo en el eje X
    public float maxX = 1.25f;  // Límite máximo en el eje X
    public float minY = -90f;   // Límite mínimo en el eje Y
    public float maxY = 90f;    // Límite máximo en el eje Y

    void Start(){
        speedMoveP = 0f;
    }
    void Update()
    {
        // Obtener la dirección de la cámara
        Vector3 forward = Camera.main.transform.forward;
        forward.y = 0; // Para evitar el movimiento en el eje Y
        forward.Normalize();



        // Mover al jugador hacia adelante en base a la dirección de la cámara
        Vector3 movement = forward * speedMoveP * Time.deltaTime;

        // Aplicar el movimiento al jugador
        transform.Translate(movement, Space.World);

        // Limitar la posición en el eje X
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, minX, maxX);
        transform.position = clampedPosition;

        
    }
}
