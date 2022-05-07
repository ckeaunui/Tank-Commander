using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject first;
    public GameObject second;
    public GameObject third;

    // Update is called once per frame
    void Update()
    {

        if(first == null && second == null && third == null){

            print("Winner");

        }
        
    }
}
