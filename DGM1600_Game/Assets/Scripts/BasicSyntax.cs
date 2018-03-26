using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour {

	// Syntax is the structure of the coding language. Some conventions are essential to read and write code.
	
	void Start () {
		// Ex: "." the dot operator is a full stop or period between words with in code. It is like an address.
		// "Debug" is the contry, "Log" is the city. We are drilling down into things that are within "Debug"
		// "transform" is the contry, "position" is the city, and "x" is the street we are trying to locate.
		// The dot operator allows you to seperate or access elements of a compound item (something that contains many elements) in Unity.

		// The ";" is used to terminate statements.
		Debug.Log (transform.position.x);

		// Indentation is not technically necessary, but make your code more legible.
		if(transform.position.y <= 5f)  {
			Debug.Log ("I'm about to hit the ground!");
		}
	// Finally commenting is use to leave, well, comments for yourself or others you're working with, or can be used to disable lines of code.
	/*This is a disabled
	multi-line
	code. */
	}
}
