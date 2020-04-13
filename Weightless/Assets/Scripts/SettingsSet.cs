using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSet : MonoBehaviour {

    public GameObject soundsButtonOn;
    public GameObject soundsButtonOff;
    public GameObject twoXButtonOn;
    public GameObject twoXButtonOff;

	void Start () {
        if(PlayerPrefs.GetInt("GameSounds") == 0){
            soundsButtonOn.SetActive(true);
            soundsButtonOff.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GameSounds") == 1)
        {
            soundsButtonOn.SetActive(false);
            soundsButtonOff.SetActive(true);
        }
        if (PlayerPrefs.GetInt("GameSpeed") == 1)
        {
            twoXButtonOn.SetActive(true);
            twoXButtonOff.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GameSpeed") == 0)
        {
            twoXButtonOn.SetActive(false);
            twoXButtonOff.SetActive(true);
        }
    }

	void Update () {
        if (soundsButtonOn.activeSelf)
        {
            PlayerPrefs.SetInt("GameSounds",0);
        }
        if(twoXButtonOn.activeSelf){
            PlayerPrefs.SetInt("GameSpeed", 1);
        }
        if (soundsButtonOn.activeSelf == false)
        {
            PlayerPrefs.SetInt("GameSounds", 1);
        }
        if (twoXButtonOn.activeSelf == false)
        {
            PlayerPrefs.SetInt("GameSpeed", 0);
        }
    }
}
