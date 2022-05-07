using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float hp;
    public int amount;
    public AudioSource sound;


    void Update()
    {
        if (hp <= 0)
        {
            sound.Play();
            Destroy(gameObject);
        }
    }
    

    void OnDestroy(){
        CashManager.instance.amount += amount;

        if(amount > 100){
            CashManager.instance.kills += 1;

        }
    }
}
