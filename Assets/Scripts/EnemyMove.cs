using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{

    public float moveSpeed;
    private int numWaypoints;
    public GameObject[] waypoints;
    private int curWaypointIndex;
    private Rigidbody2D rb;
    private Vector3 curDir;
    private Vector3 waypointOffset;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        curWaypointIndex = 0;
        numWaypoints = waypoints.Length;

    }
    /*
    void OnTriggerEnter2D(){

        if(curWaypointIndex == numWaypoints - 1){
            curWaypointIndex = 0;

        } else {
            curWaypointIndex++;
        }

    }*/

    // Update is called once per frame
    void Update()
    {

        curDir = waypoints[curWaypointIndex].transform.position;
        print(curDir);

        if(curDir.magnitude < 200 && curDir.magnitude > 50){


            print("Moving closer");

        }
        
        /*
        float angle = Vector3.Angle(Vector3.up, curDir);
        Vector3 z = Vector3.Cross(Vector3.up, curDir);

        if (z.z < 0){
            angle *= -1;
        }
        
        print(transform.position);*/

        // transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        //rb.MovePosition(rb.transform.position + curDir * moveSpeed * Time.deltaTime); 

        //transform.position += new Vector3(5, 0, 0);

    }
}
