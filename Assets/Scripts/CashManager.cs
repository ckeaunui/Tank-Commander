using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashManager : MonoBehaviour
{

    public static CashManager instance;
    public int amount;
    public int kills;

    void Awake()
    {
        if(instance == null){

            instance = this;
        } else {
            Debug.LogError("Duplicated ScoreManager, ignoring this one", gameObject);
        }
    
    }
     
}



