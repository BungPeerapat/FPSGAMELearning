using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Weapon : MonoBehaviour
{
    public GameObject Assault_Rifle_01_FPSController;
    public GameObject Handgun_01_FPSController;
    public float TAKH = Input.GetAxis("Horizontal");
    public float TAKV = Input.GetAxis("Vertical");
    public float TPTH = Input.GetAxis("Horizontal");
    public float TPTV = Input.GetAxis("Vertical");
    void FixedUpdate()
    {
        float TAKV = Input.GetAxis("Vertical");
        float TPTH = Input.GetAxis("Horizontal");
        float TPTV = Input.GetAxis("Vertical");
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
        gameObject.transform.Translate(TAKH, 0f, TAKV);
        gameObject.transform.Translate(TPTH, 0f, TPTV);
    }
};