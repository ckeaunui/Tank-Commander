using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform player;
    private float lastShot;
    public float fireInterval = 0.3f;
    public AudioSource sound;    

    void Start(){

        float lastShot = Time.time;
        
    }
    
    void Update(){

        Vector3 direction = player.position - transform.position;

        if(direction.magnitude < 220 && (Time.time - lastShot) >= fireInterval)
        {
            GameObject clone = Instantiate(prefab, transform.position, transform.rotation);
            lastShot = Time.time;
            sound.Play(); 
                
        }



    }

}
