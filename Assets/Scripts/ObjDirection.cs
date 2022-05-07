using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDirection : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> objectives;
    public int nextObj;

    
    void OnTriggerEnter2D(){

        nextObj += 1;
        print("ran");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = objectives[nextObj].transform.position - transform.position;
        float angle = Vector3.Angle(Vector3.up, direction);
        Vector3 z = Vector3.Cross(Vector3.up, direction);

        if (z.z < 0){
            angle *= -1;
        }
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));   
    }


}
