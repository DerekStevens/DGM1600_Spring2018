using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour{

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update (){
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Tima.deltaTime * 5f;
    }

    void TemperatureTest (){
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature){
            print("Coffee is too hot.");
        }

        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature){
            print("Coffee is too cold.");
        }

        // If it is neither of those then...
        else {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}