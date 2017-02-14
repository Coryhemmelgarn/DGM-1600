using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {
    //Switch statements allows a single variable to be tested against a list of values, with conditions upon each measurement. You can apply a message for the program to display for each value it could be.
    public int Strength = 10;

    // Use this for initialization
    void Start () {
        

        switch(Strength)
        {
            case 1:
                print("Bulk up!");
                break;
            case 2:
                print("Gotta lift more than that!");
                break;
            case 3:
                print("I'm starting to see a little bit of muscle in there!");
                break;
            case 4:
                print("Keep going!");
                break;
            case 5:
                print("Halfway there!");
                break;
            case 6:
                print("Over the hump");
                break;
            case 7:
                print("Mini hulk");
                break;
            case 8:
                print("Muscles, muscles, muscles");
                break;
            case 9:
                print("Very impressive");
                break;
            case 10:
                print("Superman!");
                break;
            default:
                print("Please enter a number 1-10!");
                break;

        }

	}
	
	
}
