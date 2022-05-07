using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Wallet;
    public GameObject KillsManager;
    public GameObject Ammo;

    public GameObject HealthTextObj;
    public GameObject MoneyTextObj;
    public GameObject KillsTextObj;
    public GameObject LevelTextObj;
    public GameObject LightAmmoTextObj;
    public GameObject HeavyAmmoTextObj;


    private Text HealthText;
    private Text MoneyText;
    private Text KillsText;
    private Text LevelText;
    private Text LightAmmoText;
    private Text HeavyAmmoText;

    private void Start()
    {
        HealthText = HealthTextObj.GetComponent<Text>();
        MoneyText = MoneyTextObj.GetComponent<Text>();
        KillsText = KillsTextObj.GetComponent<Text>();
        LevelText = LevelTextObj.GetComponent<Text>();
        LightAmmoText = LightAmmoTextObj.GetComponent<Text>();
        HeavyAmmoText = HeavyAmmoTextObj.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HealthText.text = "Health: " + Player.GetComponent<Health>().hp;
        MoneyText.text = "Money: " + Wallet.GetComponent<CashManager>().amount;
        KillsText.text = "Kills: " + Wallet.GetComponent<CashManager>().kills;
        LevelText.text = "Level: 1 - Tutorial";
        LightAmmoText.text = "Light Ammo: " + Ammo.GetComponent<AmmoManager>().lightAmmo;
        HeavyAmmoText.text = "Heavy Ammo: " + Ammo.GetComponent<AmmoManager>().heavyAmmo;
        
    }
}
