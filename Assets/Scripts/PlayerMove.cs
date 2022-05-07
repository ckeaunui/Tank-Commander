using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 100f;
    public float RotationSpeed = 25f;
    private float vInput;
    private float hInput;
    private Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        //sound = GetComponent<AudioSource>();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Health health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.hp = health.hp - 10;
        }
        
    }



    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space)){
            print("Space");

        }

        //Get WASD inputs
        vInput = Input.GetAxis("Vertical");
        hInput = -1 * Input.GetAxis("Horizontal");

        

        Vector3 temp = new Vector3(hInput, vInput,0);

        //Get the angle rotated from holding down A or D
        Quaternion angleRot = Quaternion.Euler(0, 0, hInput * RotationSpeed * Time.fixedDeltaTime);

        Vector3 dir = rb.transform.rotation * Vector3.up * vInput;

        rb.MovePosition(rb.transform.position + dir * MoveSpeed * Time.deltaTime); 
        rb.MoveRotation(rb.transform.rotation * angleRot);

    }

}
