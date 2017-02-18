using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //to my understanding, arrrays are a more effecient way to do a lot of "if statements". Instead of asking if something is this or that, you can simply say do this thing if its a match, and anything else just do this other thing.
    public string[] foods;
    public string food = "quesadilla";

    public string[] players;
    public string player = "Lebron James";

    public string[] things;
    public string thing = "squishy ball";

    public string[] animals;
    public string animal = "horse";

    public string[] toys;
    public string toy = "ball";

    public string[] materials;
    public string material = "felt";

    public string[] races;
    public string race = "white";

    public string[] colors;
    public string color = "blue";

    public string[] phones;
    public string phone = "verizon";

    public string[] scents;
    public string scent = "vanilla";



    // Use this for initialization
    void Start()
    {
        foreach (string foodInFoods in foods)
        {
            if (food == foodInFoods)
            {
                print("I have a match! It is " + foodInFoods);
            }
            else
            {
                print("It is not a match");
            }

            foreach (string playerInPlayers in players)
            {
                if (player == playerInPlayers)
                {
                    print("We got a baller! His name is " + playerInPlayers);
                }
                else
                {
                    print("White man can't ball");
                }
            }

            foreach (string thingInThings in things)
            {
                if (thing == thingInThings)
                {
                    print("We have the thing of things! It's a " + thingInThings);
                }
                else
                {
                    print("Keep looking for the thing");
                }
            }

            foreach (string toyInToys in toys)
            {
                if (toy == toyInToys)
                {
                    print("Dont step on the legos!");
                }
                else
                {
                    print("Keep searching");
                }
            }

            foreach (string animalInAnimals in animals)
            {
                if (animal == animalInAnimals)
                {
                    print("Look at the animal go!");
                }
                else
                {
                    print("I guess the animal died...");
                }
            }

            foreach (string raceInRaces in races)
            {
                if (race == raceInRaces)
                {
                    print("You won the race, you're so fast");
                }
                else
                {
                    print("Keep training, you're really slow");
                }
            }

            foreach (string materialInMaterials in materials)
            {
                if (material == materialInMaterials)
                {
                    print("You found the right one");
                }
                else
                {
                    print("Find something easier to work with");
                }
            }

            foreach (string colorInColors in colors)
            {
                if (color == colorInColors)
                {
                    print("Not colorblind");
                }
                else
                {
                    print("Definitely color blind");
                }
            }

            foreach (string phoneInPhones in phones)
            {
                if (thing == phoneInPhones)
                {
                    print("You get service everywhere");
                }
                else
                {
                    print("You have zero bars");
                }
            }

            foreach (string scentInScents in scents)
            {
                if (thing == scentInScents)
                {
                    print("You smell great");
                }
                else
                {
                    print("You smell like trash");
                }
            }
        }


    }
}
