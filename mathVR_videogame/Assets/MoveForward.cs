using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Puedes ajustar la velocidad según tus necesidades

    void Update()
    {
        // Mueve el GameObject hacia adelante en el eje Z
        transform.Translate(Vector3.forward * MovePlayer.speedMoveP * Time.deltaTime);
    }
}
