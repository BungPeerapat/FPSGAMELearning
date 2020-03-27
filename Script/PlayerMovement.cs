using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody PlayerRGB;
    Vector3 Movement;
    public float SpeedMovement = 6;
    Animator Animation;
    int floodMask;
    float camRayLenght = 100f;

    void Start()
    {
        PlayerRGB = GetComponent<Rigidbody>();
        Animation = GetComponent<Animator>();
    }

    void Update()
    {
        float h = Input.GetAxis("Herizontal"); //แนวนอน ซ้าย ขวา
        float v = Input.GetAxis("Vertical"); //แนวตั้ง ชึ้น ลง
        Move(h,v);
    }
    void Move (float h, float v)
    {
        Movement.Set(h, 0, v);
        Movement = Movement.normalized * SpeedMovement * Time.deltaTime;
        PlayerRGB.MovePosition (transform.position + Movement);
    }
}
