using UnityEngine;
using System.Collections;
using System.Collections.Generic;//this is first, add this
public class TeacherSolvingProblem : MonoBehaviour {
    //creating a list, and a loop, check if an element in the list is cat, print that element.
    public List<string> animals;//then this
    

	// Use this for initialization
	void Start () {
        foreach (string item in animals)
        {
            if (item == "Cat")
            {
                print(item);
            }
        }

	}
	
	
}
