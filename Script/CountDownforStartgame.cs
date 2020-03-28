using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownforStartgame : MonoBehaviour
{
    public int CountDownnumber = 0;
    public int CountDownmax;
    public Text CountDownShowText;
    private void Start()
    {

    }
    void FixedUpdate()
    {
        while(CountDownnumber <= CountDownmax)
        {
            CountDownShowText.text = CountDownnumber.ToString();
            CountDownnumber += 1;
        }

        CountDownShowText.text = "Let Start!";
        
    }
}
