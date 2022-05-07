using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Vector3.Angle(Vector3.up, direction);
        Vector3 z = Vector3.Cross(Vector3.up, direction);

        if (z.z < 0){

            angle *= -1;

        }
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        
    }
}
