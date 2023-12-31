using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveResult : MonoBehaviour
{
     // Variables para el movimiento
    public float distanciaMovimiento = 5f; // Distancia a mover en el eje X
    public float velocidadMovimiento = 2f; // Velocidad de movimiento
    public float RandomNumber;

    private Vector3 posicionInicial; // Guarda la posición inicial del objeto

    void Start()
    {
        velocidadMovimiento = Random.Range(0.5f, 1.0f);
        RandomNumber = Random.Range(0, 4);
        // Al iniciar, guarda la posición inicial del objeto
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Mueve el objeto hacia los lados en el eje X
        if(RandomNumber == 0){
            MoverObjetoX();
        }
        else if(RandomNumber == 1){
            MoverObjetoY();
        }
        else if(RandomNumber == 2){
            MoverObjetoZ();
        }
        

        // Puedes agregar otras acciones o lógica aquí según sea necesario
    }

    void MoverObjetoX()
    {
        // Calcula el nuevo valor en el eje X
        float newX = Mathf.Sin(Time.time * velocidadMovimiento) * distanciaMovimiento;

        // Aplica la nueva posición al objeto
        transform.position = new Vector3(posicionInicial.x + newX, transform.position.y, transform.position.z);
    }
    void MoverObjetoY()
    {
        // Calcula el nuevo valor en el eje Y
        float newY = Mathf.Sin(Time.time * velocidadMovimiento) * distanciaMovimiento;

        // Aplica la nueva posición al objeto
        transform.position = new Vector3(transform.position.x, posicionInicial.y + newY, transform.position.z);
    }
    void MoverObjetoZ()
    {
        // Calcula el nuevo valor en el eje Z
        float newZ = Mathf.Sin(Time.time * velocidadMovimiento) * distanciaMovimiento;

        // Aplica la nueva posición al objeto
        transform.position = new Vector3(transform.position.x, transform.position.y, posicionInicial.z + newZ);
    }
}
