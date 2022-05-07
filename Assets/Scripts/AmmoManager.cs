using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{

    public static AmmoManager instance;
    public int lightAmmo;
    public int heavyAmmo;

    void Awake()
    {
        if(instance == null){

            instance = this;
        } else {
            Debug.LogError("Duplicated ScoreManager, ignoring this one", gameObject);
        }
    
    }
     
}



