using UnityEngine;
using System.Collections;

public class ReturnFunctions2 : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject firstPlayer;

    GameObject ChooseFirstPlayer ()
    {
        int randNum = Random.Range(1, 3);
        switch (randNum)
        {
            case 1:
                return player1;
               
            case 2:
                return player2;

            default:
                return player3;
               
        }
       
    }


	// Use this for initialization
	void Start () {
        firstPlayer = ChooseFirstPlayer();
	}
	
	
}
