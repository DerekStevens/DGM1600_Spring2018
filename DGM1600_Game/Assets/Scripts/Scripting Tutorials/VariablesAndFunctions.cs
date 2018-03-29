using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour {
	// Think of Variables as boxes that contain information. You need a different type of box for each different type of information.
	// Start if the type of "box you'd like. In this case we use "int" for "integer.
	// An integer is a whole number.
	// Then name the box to identify it.
	// To finish you can end witha ";" or give it some info to hole "=  ;"
	// type nameOfVariable; type nameOfVariable = value;

	int myInt = 5;
	// The first part "int myInt" is the declaration, the second part "value;" is the initialization (whent the box is assigned something to store).

	// Start is called on when something the script is attached to enters a scene.
	void Start(){
		// When calling a function, FunctionName(data to send to parameters);
		myInt = MultiplyByTwo(myInt);

		// Used to find the value of any variable in our game and have is displayed in the console window.
		Debug.Log (myInt);
	}
		

	// A function will take the boxes that we have storing the information and will give us boxes back (return)
	// A type "void" will return nothing.
	// We tell the function what type of box (variable) to return by specifying the function type.
	// type FunctionName(type parameterName);
	// The parameter is the kind of information you want to feed this machine (function) in order to get a result back from it. 
	// "int number" is a temporary variable that is apart of the function.
		int MultiplyByTwo(int number){
			// Another temporary variable is created.
			int ret;

			ret = number * 2;

			// This return command tells the function to give us the value of "ret"
			return ret;

	}
}
