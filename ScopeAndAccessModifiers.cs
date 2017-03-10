using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Scope and access modifiers main job is to control who or what can see something. Sometimes you want to make things public so other people and scripts can see them. Other times you want them to be private so no one else can see or mess with them.
//Things are automatically made private unless you tell it to be public.
public class ScopeAndAccessModifiers : MonoBehaviour {
   //this string is public so anyone can see it.
    public string myString = "Weapon";
    //With this string, I didn't specify wether or not it is public, therefore it is private and will not show up in Unity. Then you are the only one that can access it and modify it.
    string myShield = "Wood";


	// Use this for initialization
	void Start () {
        if (myString == "Sword");
        {
            print("Don't stab me!");
        }
        if (myShield == "Wood") ;
        {
            print("Block!");
        }

    }
	
		
	}

