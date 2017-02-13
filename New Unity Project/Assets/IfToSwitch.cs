using UnityEngine;
using System.Collections;

public class IfToSwitch : MonoBehaviour {




	// Use this for initialization
	void Start () {
	    //Check for truth with one object
        if(2+2 == 4)
        {
            print(true);
        }
        if(2+2 !=5)//the exclamation point is checking to see if something is false
        {
            print(true);
        }

        int nums = 2 + 2;
        //check for true and false in a single statement
        if(nums == 5)
        {
            print(true);
        }
        else
        {
            print(false);
        }
        //check for three or more values
        switch(nums)
        {
            case 6:
                print("Well sone you have" + nums);
                break;
            case 7:
                print("Too bad, you have" + nums);
                break;
            case 8:
                print("Stop drilling, you have" + nums);
                break;

            default:
                print(nums);
                break;
        }
        




    }

	

}
