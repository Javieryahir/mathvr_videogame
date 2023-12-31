using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    GroundSpawner roadSpawner;

    void Start(){
        roadSpawner = GetComponent<GroundSpawner>();

    }
    void Updtae(){

    }
    public void SpawnTriggerIntered(){
        roadSpawner.MoveRoad();
    }
}
