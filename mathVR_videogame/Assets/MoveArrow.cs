using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        // Mueve el objeto hacia la derecha
        transform.Translate(Vector3.up * velocidad * Time.deltaTime);
    }
}
