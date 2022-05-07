using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 rootPos;
    void Start()
    {
        rootPos = new Vector3(Screen.width / 2, Screen.height / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        mousePos = Input.mousePosition;
        Vector3 direction = mousePos - rootPos;
        
        float angle = Vector3.Angle(Vector3.up, direction);
        Vector3 z = Vector3.Cross(Vector3.up, direction);

        if (z.z < 0){

            angle *= -1;

        }
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        
    }
}
