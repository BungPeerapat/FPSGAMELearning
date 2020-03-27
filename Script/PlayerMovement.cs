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

    //=========Mouse=====================
    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;
    public float minimumX = -360F;
    public float maximumX = 360F;
    public float minimumY = -60F;
    public float maximumY = 60F;
    float rotationY = 0F;

   //============Mouse==================
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
        float rv = Input.GetAxis("Mouse Y");
        //================Mouse======
        if (axes == RotationAxes.MouseXAndY)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }
        //==========Mouse==========

    }
    void Move (float h, float v)
    {
        Movement.Set(h, 0, v);
        Movement = Movement.normalized * SpeedMovement * Time.deltaTime;
        PlayerRGB.MovePosition (transform.position + Movement);
        walkanimation(h, v);
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
