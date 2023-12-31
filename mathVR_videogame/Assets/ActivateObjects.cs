using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObjects : MonoBehaviour
{
    public List<GameObject> ListObjects;
    public bool isActivated = true;
    // Start is called before the first frame update
    void Start()
    {
        if(isActivated == true){
            chooseObjects();
            isActivated =false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void chooseObjects(){
        int number = Random.Range(0, ListObjects.Count);


        for(int index = 0; index < ListObjects.Count; index++){
            if(index != number){
                Destroy(ListObjects[index]);
            }
        }
    }
    
}
