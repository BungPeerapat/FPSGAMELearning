using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSaphiArt : MonoBehaviour
{
    Animator Animator;
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); //แนวนอน ซ้าย ขวา
        float v = Input.GetAxis("Vertical"); //แนวตั้ง ชึ้น ลง
    }
    void walkanimation(float h, float v)
    {
        if (h != 0 || v != 0)
        {
            Animator.SetBool("param_idletowalk", true);
        }
    }
}
