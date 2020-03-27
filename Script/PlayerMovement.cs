using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController cotroller;
    Rigidbody PlayerRGB;
    Vector3 Movement;
    public float SpeedMovement = 0.1f;
    Animator Animator;
    int floodMask;
    float camRayLenght = 100f;
    //Mouse
    public float sensitivityY = 5F;
    //Mouse
    void Start()
    {
        PlayerRGB = GetComponent<Rigidbody>();
        Animator = GetComponent<Animator>();
        PlayerRGB.freezeRotation = true;
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); //แนวนอน ซ้าย ขวา
        float v = Input.GetAxis("Vertical"); //แนวตั้ง ชึ้น ลง
        Move(h,v);
        float rh = Input.GetAxis("Mouse X");
        LockMouseFPS(rh);
    }
    void Move (float h, float v)
    {
        Movement.Set(h, 0, v);
        Movement = Movement.normalized * SpeedMovement * Time.deltaTime;
        PlayerRGB.MovePosition (transform.position + Movement);
        walkanimation(h, v);
    }
    void LockMouseFPS (float rh)
    {
        transform.Rotate(0.0f, rh * sensitivityY * Time.deltaTime, 0.0f);
    }

    void walkanimation (float h, float v)
    {
        if (h != 0 || v != 0)
        {
            Animator.SetBool("param_idletowalk", true);
            if (SpeedMovement <= 5)
            {
                SpeedMovement = SpeedMovement + 1;
                
            }
        }
        else
            Animator.SetBool("param_idletowalk", false);
    }
}
