using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 95.0f;
    float hotLimiteTemperature = 80.0f;
    float coldestLimiteTemperature = 50.0f;


    // if the tempature of the drink is hotter than the hottest limit of drink
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;

    }


    void TemperatureTest ()
    {
        if (coffeeTemperature > hotLimiteTemperature)
        { //then do this
            print("Damn!!!too hot");
        }
        //do this if not reached
        else if (coffeeTemperature < coldestLimiteTemperature)
        {
            print("well seems like a little cold, not good");
        }

        //if just right..
         else 
        { 
            //do this
            print("hmmm,hmmm Good!! 10/10");
        }

    }
        

}
