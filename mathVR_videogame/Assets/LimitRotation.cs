using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitRotation : MonoBehaviour
{
   public float rangoMinimo = -45f;
    public float rangoMaximo = 45f;

    void Update()
    {
        // Obtén la rotación actual del gameObject en el eje Y
        float rotacionActual = transform.eulerAngles.y;

        // Aplica la limitación al rango especificado
        float nuevaRotacion = Mathf.Clamp(rotacionActual, rangoMinimo, rangoMaximo);

        // Actualiza la rotación del gameObject en el eje Y
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, nuevaRotacion, transform.eulerAngles.z);
    }
}
