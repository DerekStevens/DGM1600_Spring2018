using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	
    //An array is a collection of variables of a certain type.
    //Elements are the items in an array.
    //Array declaration: type[] nameOfArray = new type[number of elements];
	int[] myIntArray = new int[5];

    //Public arrays become visible in Unity inspector
    public GameObject[] players;

	void Start () {

        //Initialization of the array: nameOfArray[index of element to access] = value;
        //The index of an element is an integer with the first index being "0". EX: First element has the index "0", the second has the index "1", etc...
        myIntArray[0] = 12;
        myIntArray[1] = 32;
        myIntArray[2] = 23;
        myIntArray[3] = 1;
        myIntArray[4] = 1234567890;

        //FindGameObjectsWithTag returns an array of all the GameObjects in a scene with a specified tag, in this case all GameObjects with the tag "player".
        //The array this function returns will be used to initialize the public GameObject[] players; array.
        player = GameObject.FindGameObjectsWithTag("Player");

	}

    //Arrays can also be declared and initialized in the same line: type[] nameOfArray = {value, value, value, value, value};
    int[] myDeclaredInitializedArray = {12, 32, 23, 1, 1234567890};

    //Other Examples of Arrays

    private char[] chicken = new char[3];
    
    int[] eggsEaten = {1, 45, 6, 19, 234}

    new int[] howMany = new int[2];

    GameObject[] bacon = new GameObject[4];

    public char[] letters = {a ,b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z};

    new int[] daysTilSpringBreak = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    private int[] justSomeNumbers = new int[3];


    void Start () {

        chicken[0] = brown;
        chicken[1] = yellow;
        chicken[2] = white;

        howMany[0] = 45;
        howMany[1] = -304;

        bacon[0] = mmmmmmm;
        bacon[1] = ummmmmm;
        bacon[2] = uuuuuum;
        bacon[3] = uuuuuuu;

        justSomeNumbers[0] = 49586776374858999484575767658877112663456009473;
        justSomeNumbers[1] = -010202993845765748398457648394857548392238475632783495686574;
        justSomeNumbers[2] = 12345678901234567890987654321234567890987654321234567890987654321234567890987654321234567890987654323456789098765432123456789098765432123456789098765432123456789999999999987654321;
    }
}