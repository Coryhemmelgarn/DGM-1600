using UnityEngine;
using System.Collections;
//add this line below
using UnityEngine.UI;

public class FunctionsWithParametersHW : MonoBehaviour
    //Functions with parameters allow you to add input into a function
{

    public int health = 100;

    void Start()
    {
        AddHealth(50);
        print(health);
        AddHealth(25);
        print(health);
        ReplaceHealth(25, 20);
        print(health);
    }




    //this is the function, it is going to add the numbers above to health.
    //with this one you are adding the number to health
    public void AddHealth(int _h)
    {
        health += _h;
    }

    //with this one, you are reassigning health to a number
    public void ReplaceHealth(int _a, int _b)
    {
        health = _a + _b;
    }

    public void WelcomePlayer(string _name)
    {
        print("Welcome " + _name + ", it's good to have you");
    }


    public string userName;
    public InputField myInputField;

    public void UpdateStringValue(string _s)
    {
        userName += _s;
        print(userName);
    }

    public void UpdateUserName()
    {
        WelcomeUser(myInputField.text);
    }

    void WelcomeUser(string _name)
    {
        userName = _name;
        print("Welcome " + _name + ", get ready to play!");
    }




}