using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TreasureManager : MonoBehaviour
{
    public float finalSpeed = 0f;
    public int finalScore = 0;
    public int isActivated;
    public GameObject treasure;
    public int typeObject;
    public TextMeshPro textSpeed;
    public TextMeshPro textScore;
    public GameObject textObjectSpeed;
    public GameObject textObjectScore;
     // Variables para el movimiento
    public float distanciaMovimiento = 5f; // Distancia a mover en el eje X
    public float velocidadMovimiento = 2f; // Velocidad de movimiento
    public float RandomNumber;
    public GameObject SmokeObject;
    public GameObject CofreObject;
    private Vector3 posicionInicial;
    double numUse; // Guarda la posición inicial del objeto

    
 
    // Start is called before the first frame update
    void Start()
    {
        velocidadMovimiento = Random.Range(0.5f, 1.0f);
        RandomNumber = Random.Range(0, 3);
        // Al iniciar, guarda la posición inicial del objeto
        posicionInicial = transform.position;

        typeObject = Random.Range(0, 2);
        isActivated = Random.Range(0, 101);

        //Speed
        if(typeObject == 0){
            textObjectSpeed.SetActive(false);
            if(isActivated >= 0 && isActivated <= 70){

                if(PlayerPrefs.GetInt("modeGame") == 0){
                    finalSpeed = Random.Range(-1.0f, 1.0f);
                    numUse =  System.Math.Round((double)finalSpeed , 2) ;
                    finalSpeed = (float)numUse;
                    textSpeed.text = "" + finalSpeed;
                }
                else if(PlayerPrefs.GetInt("modeGame") == 1){
                    float num1 = Random.Range(0f, 0.50f);
                    float num2 = Random.Range(0f, 0.50f);
                    int typeOperation = Random.Range(0, 2);

                    if(typeOperation == 0){
                        finalSpeed = num1 +  num2;
                        numUse =  System.Math.Round((double)finalSpeed , 2) ;
                        finalSpeed = (float)numUse;
                        textSpeed.text = System.Math.Round((double)num1 , 2) +  "+"+ System.Math.Round((double)num2 , 2);

                    }
                    else{
                        finalSpeed = num1 - num2;
                        numUse =  System.Math.Round((double)finalSpeed , 2) ;
                        finalSpeed = (float)numUse;
                        textSpeed.text = System.Math.Round((double)num1 , 2) +  "-"+ System.Math.Round((double)num2 , 2);
                    }

                }
                else{
                    int num1 = Random.Range(1,9);
                    int num2 = Random.Range(1, 9);
                   
                    int typeOperation = Random.Range(0, 2);

                    if(typeOperation == 0){
                        finalSpeed = (1.0f/num1) + (1.0f/num2);
                        numUse =  System.Math.Round((double)finalSpeed , 2) ;
                        finalSpeed = (float)numUse;
                        textSpeed.text = "1/" + num1 + "+" + "1/" + num2;

                    }
                    else{
                        finalSpeed = (1.0f/num1) - (1.0f/num2);
                        numUse =  System.Math.Round((double)finalSpeed , 2) ;
                         finalSpeed = (float)numUse;
                        textSpeed.text = "1/" + num1 + "-" + "1/" + num2;
                    }
                }
            }
            else{
                treasure.SetActive(false);
            }
        }
        //Score
        else{
            textObjectScore.SetActive(false);
            if(isActivated >= 0 && isActivated <= 55){
                if(PlayerPrefs.GetInt("modeGame") == 0){
                    
                    finalScore = Random.Range(0, 1);
                    finalScore = (finalScore * 2) - 1;
                    textScore.text = "" + finalScore;
                }
                else{
                    int numero1 = Random.Range(0, 2);
                    int numero2 = Random.Range(0,2);
                    int typeop = Random.Range(0, 3);

                    bool randomBoolean = (numero1 == 0) ? false : true;
                    bool randomBoolean1 = (numero2 == 0) ? false : true;
                    bool resultado;
                    
                    if(typeop == 0){
                        resultado =  randomBoolean && randomBoolean1;
                        textScore.text = randomBoolean + " AND " + randomBoolean1;

                    }
                    else if(typeop == 1){
                        resultado =  randomBoolean || randomBoolean1;
                        textScore.text = randomBoolean + " OR "  + randomBoolean1;
                    }
                    else{
                        resultado = !randomBoolean;
                        textScore.text = "!" + randomBoolean;
                    }
                    finalScore = (resultado == true) ? 1 : -1;

                }
            }
            else{
                treasure.SetActive(false);
            }

        }

      
        
    }

    // Update is called once per frame
    void Update()
    {
        if(RandomNumber == 0){
            MoverObjetoX();
        }
    }
    public void OnTriggerEnter(Collider others)
    {
        // Verificar si el objeto que entró tiene un componente específico o tiene un tag específico.
        if (others.CompareTag("Player"))
        {
            Debug.Log("Hola");

            
            
            MovePlayer.speedMoveP += finalSpeed;
            ControllerData.numberArrows += finalScore;
            Destroy(CofreObject);
            SmokeObject.SetActive(true);
        }
    }
    void MoverObjetoX()
    {
        // Calcula el nuevo valor en el eje X
        float newX = Mathf.Sin(Time.time * velocidadMovimiento) * distanciaMovimiento;

        // Aplica la nueva posición al objeto
        transform.position = new Vector3(posicionInicial.x + newX, transform.position.y, transform.position.z);
    }
}
