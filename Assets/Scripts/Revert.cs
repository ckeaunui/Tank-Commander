using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Revert : MonoBehaviour
{
    public float start;
    public float duration;
    public string message;
    public Text text;


    // Update is called once per frame
    void Update()
    {
        if(Time.time - start > duration){

            message = "";
        } 

        text.text = message;

        
    }
}
