using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPlus : MonoBehaviour
{

    private void OnMouseDown()
    {
        PlayerPrefs.SetInt("CoinSet",PlayerPrefs.GetInt("CoinSet") + 40);
    }
}
