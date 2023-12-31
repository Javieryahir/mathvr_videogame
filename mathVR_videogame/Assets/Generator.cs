using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public List<GameObject> Listjunks;
    public int RandomNumber;
    public float posicionZ = -14.0f;
    // Start is called before the first frame update
    void Start()
    {
        

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("EndPlatform"))
        {
            RandomNumber = Random.Range(0, 2);

            
            
            posicionZ = posicionZ - 17.50f;
            

            

             Vector3 vector1 = new Vector3(3.0f, 10.0f, posicionZ);
           
            Instantiate(Listjunks[RandomNumber], vector1, Quaternion.identity);

             
        }
    }
}
