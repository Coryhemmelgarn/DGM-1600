using UnityEngine;

using System.Collections;

using System.Collections.Generic;



public class ForEachLoopsHW : MonoBehaviour
{

    //in the far left pane, drag lists over to the onmouseclick of the button. On the function click check data().

    public List<GameObject> powerUpList;

    public List<GameObject> quadList;

    public List<GameObject> planeList;

    public List<GameObject> capsuleList;



    // Use this for initialization

    public void CheckData()
    {

        foreach (GameObject item in powerUpList)

        {

            switch (item.name)

            {

                case "Quad":

                    quadList.Add(item);



                    break;



                case "Plane":

                    planeList.Add(item);



                    break;



                case "Sphere":

                    sphereList.Add(item);



                    break;

            }

        }

    }





}

