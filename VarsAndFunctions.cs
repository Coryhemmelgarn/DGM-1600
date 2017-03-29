using UnityEngine;
using System.Collections;

public class VarsAndFunctions : MonoBehaviour
{

    void RotateWheel()
    {
        //void means it functions (does work).
        //it will rotate the wheel.
    }

    string WaterFountain()
    {
        return "Water";
    }

    float VendingMachine(float money)
    {
        float coke = 1.50f;
        float change = 0;
        if (money >= coke)
        {
            change = money - coke;
            return 1.50f;
        }
        print("One coke dispensed");
        return change;




    }
}
