using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {
    //Global scope for var in this instance
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start () {
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

     

        print("The highest number you can pick is " + max + ".");
        print("The lowest number you can choose is " + min + ".");

        print("Is the number higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal.");

       

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            //basic binary tree operation
            guess = (max + min) / 2;
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
        }else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        }
    }
}
