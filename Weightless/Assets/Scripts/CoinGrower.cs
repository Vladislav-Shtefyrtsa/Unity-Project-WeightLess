using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinGrower : MonoBehaviour {

    public Text HMCText;
    public AudioSource coen;

    private void Start()
    {
        HMCText.text = PlayerPrefs.GetInt("CoinSet", 0).ToString();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Coin")
        {
            PlayerPrefs.SetInt("CoinSet", PlayerPrefs.GetInt("CoinSet") + 1);
            Destroy(coll.gameObject);
            coen.Play();
        }
    }
}
