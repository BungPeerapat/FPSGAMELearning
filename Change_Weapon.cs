using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Weapon : MonoBehaviour
{
    public GameObject Assault_Rifle_01_FPSController;
    public GameObject Handgun_01_FPSController;
    void Update()
    {
        int cw = 0;
        if (Input.GetKeyDown("c"))
        {
            cw += 1;
        }
        if (cw == 1)
        {
            Assault_Rifle_01_FPSController.SetActive(true);
            Handgun_01_FPSController.SetActive(false);
        }
        else if (cw == 2)
        {
            Assault_Rifle_01_FPSController.SetActive(false);
            Handgun_01_FPSController.SetActive(true);
        }
        else
        {
            cw = 1;
        }
    }
}
