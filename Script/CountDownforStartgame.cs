using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownforStartgame : MonoBehaviour
{
    public int CountDownnumber;
    public Text CountDownShowText;
    // Update is called once per frame
    void FixedUpdate()
    {
        while(CountDownnumber >= 3)
        {
            CountDownShowText.text = CountDownnumber.ToString();
            CountDownnumber += 1;
        }

        CountDownShowText.text = "Let Start!";
    }
}
