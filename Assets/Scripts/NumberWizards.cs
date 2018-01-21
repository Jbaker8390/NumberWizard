using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        int max = 1000;
        int min = 0;

        print("The highest number you can pick is " + max + ".");
        print("The lowest number you can choose is " + min + ".");

        print("Is the number higher or lower than 500?");
        print("Up = higher, down = lower, return = equal.");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
