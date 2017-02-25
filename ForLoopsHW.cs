using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to my knowledge, a for loop is a loop that will run over and over, but you have the option to change it each time. Like adding 1 each time, so that way it isnt the same thing running over and over, it will make changes to itself.

public class ForLoopsHW : MonoBehaviour {
    public List<string> animals;
    public List<string> cars;
    public List<string> flavors;
    public List<string> shows;
    public List<string> candy;
    public List<string> airports;
    public List<string> sports;
    public List<string> people;
    public List<string> restaraunts;
    public List<string> scents;



	// Use this for initialization
	void Start () {

        for (int i = 0; i < animals.Count; i++)
        {
            print(animals[i]);
        }

        for (int i = 0; i < cars.Count; i++)
        {
            print(cars[i]);
        }

        for (int i = 0; i < flavors.Count; i++)
        {
            print(flavors[i]);
        }

        for (int i = 0; i < shows.Count; i++)
        {
            print(shows[i]);
        }

        for (int i = 0; i < candy.Count; i++)
        {
            print(candy[i]);
        }

        for (int i = 0; i < airports.Count; i++)
        {
            print(airports[i]);
        }

        for (int i = 0; i < sports.Count; i++)
        {
            print(sports[i]);
        }

        for (int i = 0; i < people.Count; i++)
        {
            print(people[i]);
        }

        for (int i = 0; i < restaraunts.Count; i++)
        {
            print(restaraunts[i]);
        }

        for (int i = 0; i < scents.Count; i++)
        {
            print(scents[i]);
        }





    }
	

}
