using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public int objID;
    void OnTriggerEnter2D(Collider2D other)
    {
        CollectedObj obj_list = other.GetComponent<CollectedObj>();

        if(obj_list != null){
            
            obj_list.Collect(objID);
            this.transform.position = new Vector3(0, 0, -1000);           
            ObjDirection nextObjIndex = other.transform.GetChild(4).gameObject.GetComponent<ObjDirection>();

            if(nextObjIndex.nextObj == 1){
                nextObjIndex.nextObj += 1;

            }
        }
    }
}
