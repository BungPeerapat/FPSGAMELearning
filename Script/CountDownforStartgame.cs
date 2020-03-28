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
        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown()
    {
        if(CountDownnumber <= CountDownmax)
        {
            CountDownnumber += 1;

            CountDownShowText.text = CountDownnumber.ToString();

            yield return new WaitForSeconds(1F);
        }

        CountDownShowText.text = "Let Start!";

        yield return new WaitForSeconds(2f);

        CountDownShowText.gameObject.SetActive(false);

    }
}
