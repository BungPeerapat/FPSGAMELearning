using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Weapon : MonoBehaviour
{
    public GameObject Assault_Rifle_01_FPSController;
    public GameObject Handgun_01_FPSController;
    public bool ChangeWeapon;
    void Update()
    {
        if (ChangeWeapon == true)
        {
            Assault_Rifle_01_FPSController.SetActive(true);
            Handgun_01_FPSController.SetActive(false);
        }
        else
        {
            Handgun_01_FPSController.SetActive(true);
            Assault_Rifle_01_FPSController.SetActive(false);
        }
    }
}
