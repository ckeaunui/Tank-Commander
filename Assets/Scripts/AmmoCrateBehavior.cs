using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCrateBehavior : MonoBehaviour
{

    // Start is called before the first frame update
    public int lightAmmo;
    public int heavyAmmo;
    void OnTriggerEnter2D(Collider2D other)
    {
        Shoot shoot = other.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Shoot>();

        if(other.name == "Player"){
            
            Destroy(gameObject);

            AmmoManager.instance.heavyAmmo += heavyAmmo;
            shoot.heavyAmmo += heavyAmmo;
        }

    }
}

