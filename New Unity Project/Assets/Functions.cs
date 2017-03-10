using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {
    //Taking a big group of code and grouping it together into one function. It will all be executed at run time. A void function runs a set of commends. Doesnt give anything back, it just runs a set of commands. Doesnt require input, and gives no output.
    int num1 = 5;
    int num2 = 3;

	public void AddNumbers()
    {
        int sum;
        sum = num1 + num2;
        print(sum);
    }
}
