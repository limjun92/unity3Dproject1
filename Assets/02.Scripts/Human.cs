using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    // Start is called before the first frame update
    public string myName;
    private int myAge;
    private float myHeight;
    bool isSolo;

    public void Eat()
    {
        Debug.Log("³È³È ¸Ô´Â´Ù.");
    }

    public void Sleep()
    {
        Debug.Log("ÄðÄð ÀÜ´Ù.");
    }

    public void PowerPush()
    {
        Debug.Log("ÀåÀå.");
    }
}
