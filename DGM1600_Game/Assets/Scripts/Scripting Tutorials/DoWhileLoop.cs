using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

// Loops are a way to repeat lines of code. Looping or repeating is also know as iterating.

    void Start (){
        
        // Boolean is used to store the Boolean values, true and false.
        bool shouldContinue = false;

        // Do While Loops test for the condition at the end of the body. Unlike a While Loop which tests for the condition before the loop.
        // This means the body of a Do While Loops is guaranteed to run atleast once.
        // The content of the loop will continue to repeat as long as the conditional is true.
        // Do While Loop syntax "do {Loop body code} while(conditional);"
        do {
            print ("Hello World");
        }
            //Do while loops have a ";" after the conditional, while loops don't.
            while (shouldContinue == true);
    }
}