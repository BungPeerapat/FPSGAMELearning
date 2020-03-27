using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Weapon : MonoBehaviour
{
    public GameObject Assault_Rifle_01_FPSController;
    public GameObject Handgun_01_FPSController;
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Assault_Rifle_01_FPSController.SetActive(true);
            Handgun_01_FPSController.SetActive(false);
        }
        if (Input.GetKeyDown("v"))
        {
            Assault_Rifle_01_FPSController.SetActive(false);
            Handgun_01_FPSController.SetActive(true);
        }
    }
}
