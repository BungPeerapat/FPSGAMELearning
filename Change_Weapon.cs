using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Weapon : MonoBehaviour
{
    public GameObject Assault_Rifle_01_FPSController;
    public GameObject Handgun_01_FPSController;
    void FixedUpdate()
    {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                Assault_Rifle_01_FPSController.SetActive(true);
                Handgun_01_FPSController.SetActive(false);
                Tranpositionweapon();
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                Assault_Rifle_01_FPSController.SetActive(false);
                Handgun_01_FPSController.SetActive(true);
                Tranpositionweapon();
            }
    }
    void Tranpositionweapon()
    {
        float TAKH = Input.GetAxis("Horizontal");
        float TAKV = Input.GetAxis("Vertical");

        float TPTH = Input.GetAxis("Horizontal");
        float TPTV = Input.GetAxis("Vertical");
        gameObject.transform.Translate(TAKH, 0f, TAKV);
        gameObject.transform.Translate(TPTH, 0f, TPTV);
    }
};