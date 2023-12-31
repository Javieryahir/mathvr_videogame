using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAlarm : MonoBehaviour
{
    public static bool isAlarm = false;
    public GameObject AlertObject;
    public GameObject DestroyObject;
     public Comprobator scriptAInstance;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isAlarm == true && scriptAInstance.isPassed == true){
            
            AlertObject.SetActive(false);
            DestroyObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que entró tiene un componente específico o tiene un tag específico.
        if (other.CompareTag("Player"))
        {
            // Realizar acciones específicas cuando el objeto correcto entra en la zona.
            if(isAlarm == false){
                ControllerData.numberArrows--;
                AlertObject.SetActive(false);
                DestroyObject.SetActive(true);
            }
            else{
                isAlarm = false;
            }
            
        }
    }
}
