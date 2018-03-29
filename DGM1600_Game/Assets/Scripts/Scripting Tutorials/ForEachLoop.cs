using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

// Loops are a way to repeat lines of code. Looping or repeating is also know as iterating.

    void Start (){
        
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        // The For Each Loop loops through a collection item by item until it reaches the end of the collection.
        // Once it reaches the end it stops.
        // For Each Loop syntax "foreach (declare a variable the same type as the array or collection to look through, in nameOfCollection)
        foreach (string item in strings){
            // In the body we are printing out the variable "item" that we created above.
            // Eveytime the loop iterates "item" will be the value of the next element in the collection or array.
            print (item);
            // Note: You can't alter elements using a foreach loop.
        }
    }
}