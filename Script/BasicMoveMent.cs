using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoveMent : MonoBehaviour
{
     public GameObject bullet;
 
     public float speed = 5;
 
     Rigidbody2D rb;
 
 
     // Use this for initialization
     void Start () {
         rb.GetComponent<Rigidbody>();
     
     }
     
     // Update is called once per frame
     void Update () {
 
         rb.velocity = Vector2.zero;
 
         if (Input.GetKey(KeyCode.A))
         {
             rb.velocity = Vector2.left * speed;
         }
 
         if (Input.GetKey(KeyCode.D))
         {
             rb.velocity = Vector2.left * speed;
         }
 
         if (Input.GetKey(KeyCode.Space))
             {
                 GameObject go = Instantiate(bullet,
                     transform.position,
                     Quaternion.identity) as GameObject;
             }
         }
}
