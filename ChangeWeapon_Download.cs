using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon_Download : MonoBehaviour
{
     public GameObject[] weapons; // push your prefabs
 
     public int currentWeapon = 0;
     
     private int nrWeapons;
     public GameObject arms_assault_rifle_01;
     public GameObject arms_handgun_01;

    void Start() {
         
         nrWeapons = weapons.Length;
         
         SwitchWeapon(currentWeapon); // Set default gun
     
     }
     
     void Update () {
         for (int i=1; i <= nrWeapons; i++)    { 
             if (Input.GetKeyDown("" + i)) {
                 currentWeapon = i-1;
                 
                 SwitchWeapon(currentWeapon);
             
             }
         }        
 
     }
     
     void SwitchWeapon(int index) {
 
         for (int i=0; i < nrWeapons; i++)    {
             if (i == index) {
                arms_assault_rifle_01.gameObject.SetActive(true);
             } else {
                arms_handgun_01.gameObject.SetActive(false);
             }
         }
     }
}
