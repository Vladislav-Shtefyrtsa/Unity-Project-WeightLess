using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Positions : MonoBehaviour {

    public Text coinNum;
    public GameObject buttons;
    public Text LogoOne;
    public Text LogoTwo;
    public GameObject windowOne;
    public GameObject windowTwo;

	void Start () {
        Vector3 screenPoz = new Vector3(Screen.width, Screen.height, 0);
        Vector3 worldPoz = Camera.main.ScreenToWorldPoint(screenPoz);
        coinNum.transform.position = new Vector3(-worldPoz.x + 0.5f + 2.3f, -worldPoz.y + 0.5f, 0);
        if (worldPoz.x*2 <= 5.6f)
        {
            buttons.transform.localScale = new Vector3(worldPoz.x / 2.72f, worldPoz.x / 2.72f, 1);
            LogoOne.transform.localScale = new Vector3(worldPoz.x / 13.5f, worldPoz.x / 13.5f, 1);
            LogoTwo.transform.localScale = new Vector3(worldPoz.x / 13.5f, worldPoz.x / 13.5f, 1);
        }
        if (worldPoz.x * 2 <= 5.6f){
            windowOne.transform.localScale = new Vector3(worldPoz.x/5.05f,worldPoz.x/5.05f,1);
            windowTwo.transform.localScale = new Vector3(worldPoz.x /5.05f, worldPoz.x /5.05f, 1);
        }
    }
}
