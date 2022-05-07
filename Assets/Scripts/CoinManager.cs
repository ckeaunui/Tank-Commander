using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public static CoinManager instance;
    public int amount;

    void Awake()
    {
        if(instance == null){

            instance = this;
        } else {
            Debug.LogError("Duplicated ScoreManager, ignoring this one", gameObject);
        }
    
    }
     
}



