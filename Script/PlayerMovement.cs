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

    // Start is called before the first frame update
    void Start()
    {
        PlayerRGB = GetComponent<Rigidbody>();
        Animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float H = Input.GetAxis("Herizontal"); //แนวนอน ซ้าย ขวา
        float V = Input.GetAxis("Vertical"); //แนวตั้ง ชึ้น ลง
        Move(H,V);
    }
    void Move (float H, float V)
    {
        Movement.Set(H, 0, V);
        Movement = Movement.normalized * SpeedMovement * Time.deltaTime;
        PlayerRGB.MovePosition (transform.position + Movement);

    }
}
