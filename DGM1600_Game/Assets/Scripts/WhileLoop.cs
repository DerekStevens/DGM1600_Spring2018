using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

// Loops are a way to repeat lines of code. Looping or repeating is also know as iterating.

    int cupsInTheSink = 4;

    void Start (){

        // While loop structure "while(conditional)
        // The content of the loop will continue to repeat as long as the conditional is true.
        while(cupsInTheSink > 0){
            //The code within the braces is the code that is repeated.
            print ("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}