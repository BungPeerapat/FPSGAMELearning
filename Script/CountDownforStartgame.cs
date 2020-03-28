using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownforStartgame : MonoBehaviour
{
    public int CountDownnumber = 0;
    public int CountDownmax;
    public Text TextCountDown;
    public void Start()
    {
        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown()
    {
        while(CountDownnumber > CountDownmax)
        {

            TextCountDown.text = CountDownnumber.ToString();

            yield return new WaitForSeconds(1F);

            CountDownnumber++;
        }

        TextCountDown.text = "Let Start!";

        yield return new WaitForSeconds(2f);

        TextCountDown.gameObject.SetActive(false);

    }
}
