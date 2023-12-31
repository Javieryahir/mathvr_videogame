using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprobator : MonoBehaviour
{
    public bool isPassed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider others)
    {
        // Verificar si el objeto que entró tiene un componente específico o tiene un tag específico.
        if (others.CompareTag("Player"))
        {
            
            isPassed = true;
        }
    }
}
