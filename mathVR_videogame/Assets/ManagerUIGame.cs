using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerUIGame : MonoBehaviour
{
    public GameObject screenMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame(){
        screenMenu.SetActive(false);
        MovePlayer.speedMoveP =  1.0f;
    }
    public void Back(){
        SceneManager.LoadScene("menuScene");
    }
}
