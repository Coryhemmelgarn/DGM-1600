using UnityEngine;
using System.Collections;

public class Mathoperators : MonoBehaviour {

    public int addition = 12 + 4;
    public int subtraction = 12 - 4;
    public float division = 5.0f / 2.0f;
    public int multiplication = 10 * 2;
    public int remainder = 7 % 2;



	
	void Start () {
        addition += 9;//+= means add to what we have up top.
        subtraction -= 10;//subtract from 
        addition += 3;
        addition = 1; 
	}
	

}
