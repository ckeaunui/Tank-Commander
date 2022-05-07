using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCheck : MonoBehaviour
{
    public int requiredId;
    public GameObject prefab;


    void OnTriggerEnter2D(Collider2D other)
    {
        CollectedObj objs = other.GetComponent<CollectedObj>();

        if(objs != null){

            if(objs.objItems.Contains(requiredId))
            {
                print("Lets gooo");
                Destroy(prefab);

            } else {

                print("You lack a key");
            }

        }

        


    }
}
