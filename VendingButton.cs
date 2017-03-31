using UnityEngine;
using System.Collections;

public class VendingButton : MonoBehaviour {

    public MoneyInputs moneyInput;

    public string productName = "Coke";
    public float productPrice = 1.5f;

	float VendProduct(float money)
    {
        print("Vending " + productName + ".");
        return money - productPrice;
    }

    public void ButtonClick()
    {
        print("$" + VendProduct(moneyInput.MoneyToFloat()) + " is your change");
    }
}
