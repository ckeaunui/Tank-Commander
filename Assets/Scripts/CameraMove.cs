using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset;

    void Start(){

        offset = this.transform.position - player.transform.position;
    }
    // Start is called before the first frame update
    void LateUpdate()
    {
        this.transform.position = player.transform.position + offset;
        
    }
}
