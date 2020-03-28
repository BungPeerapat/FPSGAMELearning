using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownforStartgame : MonoBehaviour
{
    public int CountDownnumber;
    public Text CountDownShowText;
    private void Start()
    {
        StartCoroutine()
    }
    void FixedUpdate()
    {
        while(CountDownnumber >= 3)
        {
            CountDownShowText.text = CountDownnumber.ToString();
            CountDownnumber += 1;
        }

        CountDownShowText.text = "Let Start!";
        CountDown_Text.ga
    }
}
