using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject light;
    public GameObject heavy;
    private float lastShot;
    public float fireInterval = 0.3f;
    public AudioSource sound;
    public int heavyAmmo = 3;
    public GameObject stored;


    void Start(){

        float lastShot = Time.time;
        sound = GetComponent<AudioSource>();
        
    }
    

    // Update is called once per frame
    void Update()
    {

        heavyAmmo = stored.GetComponent<AmmoManager>().heavyAmmo;

        if(Input.GetKeyDown(KeyCode.Mouse0) && (Time.time - lastShot) >= fireInterval)
        {
            GameObject clone = Instantiate(light, transform.position, transform.rotation);
            lastShot = Time.time;
            sound.Play();
                
        } 
        else if(Input.GetKeyDown(KeyCode.Mouse1) && (Time.time - lastShot) >= fireInterval && stored.GetComponent<AmmoManager>().heavyAmmo > 0)
        {
            GameObject clone = Instantiate(heavy, transform.position, transform.rotation);
            lastShot = Time.time;
            sound.Play();
            stored.GetComponent<AmmoManager>().heavyAmmo -= 1;

        }
        
    }
}
