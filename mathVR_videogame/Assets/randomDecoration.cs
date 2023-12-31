using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDecoration : MonoBehaviour
{
    // three main decorations
    public List<GameObject> decorationMain;

    //four decorations floor
    public List<GameObject> decorationSec;

    // three rocks
    public List<GameObject> decorationRocks;


    public int Random1;
    public int RandomNumber;
    public int RandomNumber2;
    public int RandomNumber3;


    // Start is called before the first frame update
    void Start()
    {
        firstRandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void firstRandom(){
        Random1 = Random.Range(0, 2);

        if(Random1 == 1){
            RandomNumber = Random.Range(0, decorationMain.Count);
        decorationMain[RandomNumber].SetActive(true);

      
        if(RandomNumber == 0){
            RandomNumber2 = Random.Range(0, decorationSec.Count);
            decorationSec[RandomNumber2].SetActive(true);

          
            
            float alturaActual = decorationMain[RandomNumber].transform.position.y;
            float restaAleatoria = Random.Range(0f, 1f);
            float nuevaAltura = alturaActual - restaAleatoria;
            Vector3 nuevaPosicion = decorationMain[RandomNumber].transform.position;
            nuevaPosicion.y = nuevaAltura;
            decorationMain[RandomNumber].transform.position = nuevaPosicion;
        }
        else if(RandomNumber == 1){
            RandomNumber3 = Random.Range(0, decorationRocks.Count);
            decorationRocks[RandomNumber3].SetActive(true);
        }
        }
        
        


    }
    
    
}
