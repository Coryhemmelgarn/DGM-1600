using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour {

    public string string1;
    public string string2;

	// Use this for initialization
	public void OnButtonClick () {
	    if(string1 == "Thing 1" && string2 == "Thing 2")//both things have to be true for this to work
        {
            print("These things are quite tame");
        }

        if(string1 == "Thing 1" || string2 == "Thing 2")//Either or. Only one has to be true.
        {
            print("It's fun to have fun if you know what to do");
        }

        if(string1 != "Thing 1" && string2 != "Thing 2")//both of these things have to be false to print.
        {
            print("Oh what a shame, what a shame, what a shame.");
        }
	}
	

	}

