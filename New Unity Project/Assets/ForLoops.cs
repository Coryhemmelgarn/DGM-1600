using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ForLoops : MonoBehaviour {
    public List<string> cars;


	// Use this for initialization
	void Start () {
        for (int i = 0; i < cars.Count; i++)
        {
            print(cars[i]);
        }    


	}
	
	
}
