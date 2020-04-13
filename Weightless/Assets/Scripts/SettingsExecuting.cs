using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsExecuting : MonoBehaviour {

    public GameObject Audios;
    public GameObject AudioOne;

	void Update () {
        if(PlayerPrefs.GetInt("GameSounds") == 0){
            Audios.SetActive(true);
            AudioOne.SetActive(true);
        }
        if (PlayerPrefs.GetInt("GameSounds") == 1)
        {
            Audios.SetActive(false);
            AudioOne.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GameSpeed") == 1){
            Time.timeScale = 1.5f;
        }
        if (PlayerPrefs.GetInt("GameSpeed") == 0)
        {
            Time.timeScale = 1f;
        }
    }
}
