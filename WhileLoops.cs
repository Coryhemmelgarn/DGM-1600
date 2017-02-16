using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

    int i = 10;
    public string[] cereals;
    public string[] Numbers;
    public string[] Things;
    public string[] Stuff;
    public string[] Phones;
    public string[] Flavors;
    public string[] Scents;
    public string[] Schools;
    public string[] Teams;
    public string[] Players;

    //to my understanding, a while loop is a block of code that will continue to run over and over until it no longer continues to be true.
    // Use this for initialization
    void Start () {
        while (i < cereals.Length)
        {
            print(cereals[i]);
            i++;
        }
        print("Done");

        while (i < Numbers.Length)
        {
            print(Numbers[i]);
            i++;
        }
        print("Done");

        while (i < Things.Length)
        {
            print(Things[i]);
            i++;
        }
        print("Done");

        while (i < Stuff.Length)
        {
            print(Stuff[i]);
            i++;
        }
        print("Done");

        while (i < Phones.Length)
        {
            print(Phones[i]);
            i++;
        }
        print("Done");

        while (i < Flavors.Length)
        {
            print(Flavors[i]);
            i++;
        }
        print("Done");

        while (i < Scents.Length)
        {
            print(Scents[i]);
            i++;
        }
        print("Done");

        while (i < Schools.Length)
        {
            print(Schools[i]);
            i++;
        }
        print("Done");

        while (i < Teams.Length)
        {
            print(Teams[i]);
            i++;
        }
        print("Done");

        while (i < Players.Length)
        {
            print(Players[i]);
            i++;
        }
        print("Done");

      


    }
	
	
}
