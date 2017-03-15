﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReturnFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float[] scores = { 24f, 68f, 100f, 86f };
        Average(scores);
        print(Average(scores));

        float sumOfAllNumbers;
        sumOfAllNumbers = Sum((Sum(4.6f, 8.2f)), Sum(2.4f, 6.6f));
        print(sumOfAllNumbers);
	}
	
	float Sum(float num1, float num2)
    {
        float sum;
        sum = num1 + num2;
        return sum;
    }

    float Average(float[] scores)
    {
        float sum = 0;
        float average;
        foreach(float score in scores)
        {
            sum += score;
        }
        average = sum / scores.Length;
        return average;
    }


}
