using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ManagerUi : MonoBehaviour
{
    
    public int modeGame;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textDistance;
    public TextMeshProUGUI textMode;
    public string level = "Easy";


    // Start is called before the first frame update
    void Start()
    {
       textScore.text = "" + PlayerPrefs.GetInt("maxScore"); 
       textDistance.text = "" + PlayerPrefs.GetInt("maxDistance");
       


        if(PlayerPrefs.GetInt("modeGame") == 0){
            textMode.text = "Easy";
        }
        else if(PlayerPrefs.GetInt("modeGame") == 0){
            textMode.text = "Medium";
        }
        else{
            textMode.text = "Hard";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame(){
        SceneManager.LoadScene("gamescene");
    }
    public void Button1(){
        PlayerPrefs.SetInt("modeGame", 0);
        
        textMode.text = "Easy";
    }
    public void Button2(){
       PlayerPrefs.SetInt("modeGame", 1);
       
       textMode.text = "Medium";
    }
    public void Button3(){
        PlayerPrefs.SetInt("modeGame", 2);

        textMode.text = "Hard";


    }
}
