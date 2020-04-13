using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockCollectSky : MonoBehaviour {

    public GameObject parentSky;
    public GameObject Locked;
    public Text scoree;

    private void OnMouseDown()
    {
        if(PlayerPrefs.GetInt("CoinSet") >= 20){
            PlayerPrefs.SetInt("CoinSet", PlayerPrefs.GetInt("CoinSet") - 20);
            scoree.text = PlayerPrefs.GetInt("CoinSet").ToString();
            Locked.SetActive(false);
            PlayerPrefs.SetString("SkyNames",PlayerPrefs.GetString("SkyNames") + parentSky);
        }
    }
}
