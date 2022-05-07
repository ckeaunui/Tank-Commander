using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{

    public float speed;

    void FixedUpdate()
    {
        //rb.MovePosition(rb.transform.position + Vector3.up * speed * Time.deltaTime);
        transform.Translate(0, speed * Time.deltaTime, 0);

    }

}
