using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockedUnlock : MonoBehaviour {

    public GameObject MyBall;
    public Text scoree;

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("CoinSet") >= 20)
        {
            PlayerPrefs.SetString("LockingH", PlayerPrefs.GetString("LockingH") + MyBall.name);
        
        this.gameObject.SetActive(false);
       
            PlayerPrefs.SetInt("CoinSet", PlayerPrefs.GetInt("CoinSet") - 20);
            scoree.text = PlayerPrefs.GetInt("CoinSet").ToString();
        }
    }
}
