using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ControllerData : MonoBehaviour
{
    private Vector3 lastPosition;
    private double totalDistance;
    public TextMeshProUGUI textDistance;
    public TextMeshProUGUI textArrows;
    public static int numberArrows = 3;

    public GameObject objectPanel;


    void Start()
    {
        lastPosition = transform.position;
        numberArrows = 3;
    }

    void Update()
    {
        // Calcula la distancia entre la posición actual y la última posición conocida
        double distance = Vector3.Distance(transform.position, lastPosition);

        // Actualiza la distancia total recorrida
        totalDistance += distance;

        // Actualiza la última posición conocida
        lastPosition = transform.position;

        
        textDistance.text =   System.Math.Round(totalDistance, 0) + "m";
        textArrows.text = "Score: " + numberArrows;

        if(numberArrows > PlayerPrefs.GetInt("maxScore")){
                PlayerPrefs.SetInt("maxScore", numberArrows);
        }
        
        if(numberArrows <= 0 || MovePlayer.speedMoveP < 0.0f || MovePlayer.speedMoveP > 5.0f){
            if((int)totalDistance > PlayerPrefs.GetInt("maxDistance")){
                
                PlayerPrefs.SetInt("maxDistance", (int)totalDistance);
            }

            
            SceneManager.LoadScene("gamescene");
        }
    }

    public void ResetDistance()
    {
        totalDistance = 0f;
        lastPosition = transform.position;
    
    }

    
}
