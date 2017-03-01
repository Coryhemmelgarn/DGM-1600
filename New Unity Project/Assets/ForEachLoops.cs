using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ForEachLoops : MonoBehaviour {
    //in the far left pane, drag lists over to the onmouseclick of the button. On the function click check data().
    public List<GameObject> powerUpList;
    public List<GameObject> cubeList;
    public List<GameObject> sphereList;
    public List<GameObject> capsuleList;

	// Use this for initialization
	public void CheckData () {
        foreach (GameObject item in powerUpList)
        {
            switch (item.name)
            {
                case "Cube":
                    cubeList.Add(item);

                    break;

                case "Capsule":
                    capsuleList.Add(item);

                    break;

                case "Sphere":
                    sphereList.Add(item);

                    break;
            }
        }
	}
	

}
