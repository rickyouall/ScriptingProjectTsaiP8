using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //create a variable of type integer
    int MyInt = 8;






    // Start is called before the first frame update
    void Start()
    {
        //iam going to multiply throught my functuion to multiply it by 2
        MyInt = MultiplyByTwo(MyInt);
        // I'm going to print the results to the console
        Debug.Log(MyInt);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Creating a funtion that takes a int parameter and multiploes it by 2
    int MultiplyByTwo(int number)
    {
        //creating a variable that store my results
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the result
        return results;

    }
   

}
