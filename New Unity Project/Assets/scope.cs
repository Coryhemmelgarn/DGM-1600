using UnityEngine;
using System.Collections;

public class scope : MonoBehaviour {

    public string owner = "Bob";
    private string renter = "Kate";

   public void Awake()
    {
        string cat = "Joe";
        if (cat == "Joe")
        {
            print(renter);
            string mouse = "Helen";
            print(cat+ " ate "+ mouse);
        }
        print(cat);
        print(owner);
    }

	void Start () {
        string cat = "Frank";
        print(cat);
        print(owner);
	}
	
	
}
