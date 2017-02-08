using UnityEngine;
using System.Collections;

public class ElseClause : MonoBehaviour {


    public string password;
    public bool userAgreement;


	// Use this for initialization
	void Start () {
	
        if(password == "OU812" && userAgreement)//if you substitiute "&&" with "||" then it is an or statement, both things dont need to be true. Just one needs to be correct to print true.
            //constants and only two outcomes are they only reason you should ever use an if statement.
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }


	}
	
}
