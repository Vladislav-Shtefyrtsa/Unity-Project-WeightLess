using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSkyDestroy : MonoBehaviour {

    public GameObject lockedone, lockedtwo, lockedthree, lockedfour, lockedfive, lockedsix, lockedseven, lockedeight;

	void Update () {
        if(PlayerPrefs.GetString("SkyNames").Contains("ThemeOne")){
            lockedone.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeTwo"))
        {
            lockedtwo.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeThree"))
        {
            lockedthree.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeFour"))
        {
            lockedfour.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeFive"))
        {
            lockedfive.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeSix"))
        {
            lockedsix.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeSeven"))
        {
            lockedseven.SetActive(false);
        }
        if (PlayerPrefs.GetString("SkyNames").Contains("ThemeEight"))
        {
            lockedeight.SetActive(false);
        }
    }
}
