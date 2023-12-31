using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GroundSpawner : MonoBehaviour
{
    public List<GameObject> roads;
    public float offset = 60f;
    // Start is called before the first frame update
    void Start()
    {
        if(roads != null && roads.Count > 0){
            roads = roads.OrderBy(r => r.transform.position.x ).ToList();
        }
    }

    // Update is called once per frame
    public void MoveRoad()
    {
       GameObject moveRoad = roads[0];
       roads.Remove(moveRoad);

       float newZ = roads[roads.Count - 1].transform.position.x + offset;
       moveRoad.transform.position = new Vector3(newZ,0, 0);
       roads.Add(moveRoad); 
    }
}
