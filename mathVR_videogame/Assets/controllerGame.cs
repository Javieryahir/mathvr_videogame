
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using System.Data;
using TMPro;

public class controllerGame : MonoBehaviour
{
    public int firstNumber;
    public int secondNumber;
    public int thirdNumber;
    public int fourthNumber;
    public int typeroperation;

  
    public string getOperation;
    public int getResult;
    public int getResultAdvance;

    public double getResultIntegral;

     public TextMeshPro textoTMPro;
    
    public List<GameObject> miniplatforms;
    public List<TextMeshPro> textList;

    public int GetRandomIndex = 0;

    public int Mode = 0;


    public int descativateN = 5;

    public int chooseElements;

     private string[] operadores = { "+", "-", "*", "/", };



    


    // Start is called before the first frame update
    void Start()
    {
        Mode = PlayerPrefs.GetInt("modeGame"); 

        int NumberDesactivate = Random.Range(0, descativateN);

        var indicesAleatorios = new HashSet<int>();
        
        while (indicesAleatorios.Count < NumberDesactivate)
        {
            int indiceAleatorio = Random.Range(0, miniplatforms.Count);
            indicesAleatorios.Add(indiceAleatorio);
        }

        // Desactiva los componentes correspondientes
        foreach (int indice in indicesAleatorios)
        {
            miniplatforms[indice].SetActive(false);
        }
        
        if(Mode == 0){
            operationEasy();
        }
        else if(Mode == 1){
            operationMedium();
        }
        else {
            operationAdvance();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void operationEasy(){
        typeroperation = Random.Range(0, 3);

        // Suma 
        if(typeroperation == 0){
            //Get Numbers
            firstNumber = Random.Range(1,20);
            secondNumber = Random.Range(1, 20);

            getResult = firstNumber + secondNumber;

            textoTMPro.text = firstNumber + "+" + secondNumber;

            

            

            

        }
        // Resta
        else if(typeroperation == 1){
    
            firstNumber = Random.Range(10,20);
            secondNumber = Random.Range(1,9);

            getResult = firstNumber - secondNumber;

            textoTMPro.text = firstNumber + "-" + secondNumber;

        }
        else{
            firstNumber = Random.Range(2,10);
            secondNumber = Random.Range(1,10);

            getResult = firstNumber * secondNumber;

            textoTMPro.text = firstNumber + "x" + secondNumber;
        }

        GetRandomIndex = Random.Range(0, miniplatforms.Count);

        while(!miniplatforms[GetRandomIndex].activeSelf){
             GetRandomIndex = Random.Range(0, miniplatforms.Count);
        }

        for(int index = 0; index < miniplatforms.Count; index++){
            if(miniplatforms[index].activeSelf){
                 if(index == GetRandomIndex){
                    textList[index].text = "" + getResult;
                    miniplatforms[index].tag = "objective";
                }else{
                    int number = getResult-Random.Range(-10, 10);
                    while(number <= 0 || number == getResult){
                        number = getResult-Random.Range(-10, 10);
                    }
                    textList[index].text = "" + number;
                }
            }
               
        }
    }
    void operationAdvance(){
        typeroperation = Random.Range(0, 2);

        //Derivate
         if(typeroperation == 0){
            //Get Numbers

            //first type derivate


            firstNumber = Random.Range(1,20);
            secondNumber = Random.Range(1, 20);

            getResult = firstNumber * secondNumber;
            getResultAdvance = secondNumber - 1;

            textoTMPro.text = "d/dx " + firstNumber + "x^" + secondNumber;

            
            GetRandomIndex = Random.Range(0, miniplatforms.Count);

        while(!miniplatforms[GetRandomIndex].activeSelf){
             GetRandomIndex = Random.Range(0, miniplatforms.Count);
        }

            for(int index = 0; index < miniplatforms.Count; index++){
                 if(miniplatforms[index].activeSelf){
                    if(index == GetRandomIndex){
                    textList[index].text = getResult + "x^" + getResultAdvance;
                    miniplatforms[index].tag = "objective";
                }else{
                    int number = getResult-Random.Range(-10, 10);
                    int number1 = getResultAdvance - Random.Range(-10,10);
                    while(number <= 0 || number == getResult){
                        number = getResult-Random.Range(-10, 10);
                        number1 = getResultAdvance - Random.Range(-10,10);
                    }
                    textList[index].text = number + "x^" + number1;
                }
                 }
                
        }
            

            

        }
        // Integral
        else{
    
            firstNumber = Random.Range(1,20);
            secondNumber = Random.Range(1, 20);

            getResultIntegral = firstNumber/(secondNumber + 1.0f); 
            getResultIntegral =  System.Math.Round(getResultIntegral, 2);
            getResultAdvance = secondNumber + 1;

            textoTMPro.text = "∫" + firstNumber + "x^" + secondNumber;

            GetRandomIndex = Random.Range(0, miniplatforms.Count);

        while(!miniplatforms[GetRandomIndex].activeSelf){
             GetRandomIndex = Random.Range(0, miniplatforms.Count);
        }

            for(int index = 0; index < miniplatforms.Count; index++){
                if(miniplatforms[index].activeSelf){
                    if(index == GetRandomIndex){
                    textList[index].text = getResultIntegral + "x^" + getResultAdvance;
                    miniplatforms[index].tag = "objective";
                }else{
                    double number = getResultIntegral - Random.Range(-10, 10);
                    int number1 = getResultAdvance - Random.Range(-10,10);
                    while((number <= 0 && number == getResult ) && (number1 <= 0 && number1 == getResult )){
                        number = getResultIntegral -Random.Range(-10, 10);
                        number1 = getResultAdvance - Random.Range(-10,10);
                    }
                    textList[index].text = number + "x^" + number1;
                }
                }
                
            }

        }
    }
    void operationMedium(){
        typeroperation = Random.Range(0, 2);

        //Ecuations Systems
         if(typeroperation == 0){
            //Get Numbers

            //first type derivate


            firstNumber = Random.Range(-10, 10);
            secondNumber = Random.Range(-10, 10);

            thirdNumber = Random.Range(-10, 10);
            fourthNumber = Random.Range(-10,10);


            while(firstNumber == 0 || secondNumber == 0 || thirdNumber == 0 || fourthNumber == 0){
                firstNumber = Random.Range(-10, 10);
            secondNumber = Random.Range(-10, 10);

            thirdNumber = Random.Range(-10, 10);
            fourthNumber = Random.Range(-10,10);
            }
           
            

            chooseElements = Random.Range(0, 2);

            



            switch (chooseElements)
            {
            case 0:
                // Ecuación de la forma: ax + b = 0
                textoTMPro.text = $"{firstNumber}x + ({secondNumber}) = 0";
                SolveLinearEquationAxBEqualsC(firstNumber, secondNumber);
                break;

            case 1:
                // Ecuación de la forma: ax + b = cx + d
                textoTMPro.text = $"{firstNumber}x + ({secondNumber}) = {thirdNumber}x + ({fourthNumber})";
                SolveLinearEquationAxBEqualsCxD(firstNumber, secondNumber, thirdNumber, fourthNumber);
                break;

            // Agregar más casos según sea necesario

            default:
                Debug.LogError("Tipo de ecuación no reconocido.");
                break;
            }



        

            
                
        }
            

            

        
        //GetOperacion
        else{
    
            int num1 = Random.Range(1, 10);
        int num2 = Random.Range(1, 10);
        int num3 = Random.Range(1, 10);
        int num4 = Random.Range(1, 10);
        int typeOperation = Random.Range(0, 11); // Ajustado a 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11

        switch (typeOperation)
        {
            case 0:
                getResultIntegral = num1 - num2 + num3 * num4;
                textoTMPro.text = $"{num1} - {num2} + {num3} * {num4}";
                break;
            case 1:
                getResultIntegral = (num1 - num2) / (num3 + num4);
                textoTMPro.text = $"({num1} - {num2}) * ({num3} + {num4})";
                break;
            case 2:
                getResultIntegral = (num1 - num2) + (num3-(-num4));
                textoTMPro.text = $"({num1} - {num2}) + [{num3} - (-{num4})]";
                break;
            case 3:
                getResultIntegral = num1 * (num2 + num3) / num4;
                textoTMPro.text = $"{num1} * ({num2} + {num3}) - {num4}";
                break;
            case 4:
                getResultIntegral = (num1 + num2) * Math.Pow(num3, 2);
                textoTMPro.text = $"({num1} + {num2}) * {num3}^{2}";
                break;
            case 5:
                getResultIntegral = num1 / num2 - Math.Pow(num3, 2);
                textoTMPro.text = $"{num1} / {num2} - {num3}^{2}";
                break;
            case 6:
                getResultIntegral = (num1 + num2) * (num3 - num4);
                textoTMPro.text = $"({num1} + {num2}) * ({num3} - {num4})";
                break;
            case 7:
                getResultIntegral = num1 * num2 - num3 / num4;
                textoTMPro.text = $"{num1} * {num2} - {num3} / {num4}";
                break;
            case 8:
                getResultIntegral = num1 - num2 * num3 + num4;
                textoTMPro.text = $"{num1} - {num2} * {num3} + {num4}";
                break;
            case 9:
                getResultIntegral = (num1 + num2) / (num3 + num4);
                textoTMPro.text = $"({num1} + {num2}) / ({num3} + {num4})";
                break;
            case 10:
                getResultIntegral = num1 * num2 / (num3 + num4);
                textoTMPro.text = $"{num1} * {num2} / ({num3} + {num4})";
                break;
            default:
                getResultIntegral = num1 + num2 + num3 + num4; // Suma por defecto
                textoTMPro.text = $"{num1} + {num2} + {num3} + {num4} (Default)";
                break;
        }

        

        }


        GetRandomIndex = Random.Range(0, miniplatforms.Count);

        while(!miniplatforms[GetRandomIndex].activeSelf){
             GetRandomIndex = Random.Range(0, miniplatforms.Count);
        }

        for(int index = 0; index < miniplatforms.Count; index++){
            if(miniplatforms[index].activeSelf){
                 if(index == GetRandomIndex){
                    textList[index].text = "" + getResultIntegral;
                    miniplatforms[index].tag = "objective";
                }else{
                    double number = getResultIntegral-Random.Range(-10, 10);
                    while(number == getResultIntegral){
                        number = getResultIntegral-Random.Range(-10, 10);
                    }
                    textList[index].text = "" + number;
                }
            }
               
        }
    }

    void SolveLinearEquationAxBEqualsC(int a, int b)
    {
        // Ecuación: ax + b = 0
        getResultIntegral = (-b+0.0f) / (a + 0.0f);
        getResultIntegral =  System.Math.Round(getResultIntegral, 2);
        
    }

    void SolveLinearEquationAxBEqualsCxD(int a, int b, int c, int d)
    {
        // Ecuación: ax + b = cx + d
        getResultIntegral = ((d - b) * 1.0f) / ((a - c) * 1.0f);
        getResultIntegral =  System.Math.Round(getResultIntegral, 2);
       
    }
     

}

    
    
