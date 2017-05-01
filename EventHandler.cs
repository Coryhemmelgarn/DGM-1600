using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventHandler : MonoBehaviour {
	public GameObject result;
	private Text resultText;
	private int maxDigits = 11;
	private string currentNumber = "0";
	private string currentOperationToPerform = "";
	private bool isFirst = true;
	private bool shouldClearScreen = false;
	private ArrayList ops = new ArrayList();
	private ArrayList nums = new ArrayList ();
	private float[] registers = new float[2];

	// Use this for initialization
	void Start () {
		ops.Add("+");
		ops.Add("-");
		ops.Add("/");
		ops.Add("*");
		nums.Add("0");
		nums.Add("1");
		nums.Add("2");
		nums.Add("3");
		nums.Add("4");
		nums.Add("5");
		nums.Add("6");
		nums.Add("7");
		nums.Add("8");
		nums.Add("9");
		resultText = result.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void buttonClicked(string button) {
		if (button == "=") {
			PerformOperation ();
		} else if (ops.Contains(button)) {
			OperatorPressed (button);
		} else if (nums.Contains(button)) {
			AppendNumber (button);
		} else if (button == ".") {
			if (!currentNumber.Contains(".") || shouldClearScreen) {
				AppendNumber(".");
			}
		}
	}

	private void OperatorPressed(string op) {
		StoreCurrentNumberInReg(0);
		isFirst = false;
		shouldClearScreen = true;
		currentOperationToPerform = op;
	}

	private void ClearCalcData() {
		isFirst = true;
		shouldClearScreen = true;
		currentOperationToPerform = "";
		currentNumber = "0";
		for(int i = 0; i < registers.Length; i++)
			registers[i] = 0;
	}

	private void PerformOperation() {
		switch(currentOperationToPerform) {
		case "+":
			if(currentNumber != "NaN")
				currentNumber = (registers[0] + registers[1]).ToString();
			break;
		case "-":
			if(currentNumber != "NaN")
				currentNumber = (registers[0] - registers[1]).ToString();
			break;
		case "*":
			if(currentNumber != "NaN")
				currentNumber = (registers[0] * registers[1]).ToString();
			break;
		case "/":
			if(currentNumber != "NaN")
				currentNumber = (registers[1] != 0) ? (registers[0] / registers[1]).ToString()   :   "NaN";
			break;
		case "":
			break;
		default:
			Debug.LogError("Unknown operation: " + currentOperationToPerform);
			break;
		}
		resultText.text = currentNumber;
		StoreCurrentNumberInReg(0);
		isFirst = true;
		shouldClearScreen = true;
	}

	private void StoreCurrentNumberInReg(int regNumber) {
		registers[regNumber] = float.Parse(currentNumber);
	}

	private void AppendNumber(string s) {
		if ((currentNumber == "0") || shouldClearScreen) {
			currentNumber = (s == ".") ? "0." : s;
		} else {
			if (currentNumber.Length < maxDigits) {
				currentNumber += s;
			}
		}
		if (shouldClearScreen) {
			shouldClearScreen = false;
		}
		StoreCurrentNumberInReg(isFirst ? 0 : 1);
		resultText.text = currentNumber;
	}

}
