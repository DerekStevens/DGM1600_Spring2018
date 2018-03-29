using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

// Loops are a way to repeat lines of code. Looping or repeating is also know as iterating.

    int numEnemies = 3;

    void Start (){

        /* For loop syntax "for (1st; 2nd; 3rd) {Loop body code}"
        1st Section: (optional) Gives a place to declare and initialize variables
                    - This section will run one time at the beginning of the loop.
        2nd Section: (must be supplied) Conditional 
                    - This conditional will be evaluated before every iteration of the loop.
        3rd Section: (optional) Allows us to increment or decrement any variables we would like
                    - THis section will run after every iteration of the loop.
            Note: a ";" not a "," seperates the different sections */
        for (int i = 0; i < numEnemies; i++){
            print ("Creating enemy number: " + i);
        }
    }
}