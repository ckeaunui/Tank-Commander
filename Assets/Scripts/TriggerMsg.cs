using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TriggerMsg : MonoBehaviour
{
    // Start is called before the first frame update
    public Text objText;
    public float msgLen = 10f;
    public float startMsg;
    public string message;


    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            
            objText.GetComponent<Revert>().start = Time.time;
            objText.GetComponent<Revert>().duration = msgLen;
            objText.GetComponent<Revert>().message = message;
            

        }
        
    }
}
