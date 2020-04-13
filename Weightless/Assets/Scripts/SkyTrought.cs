using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyTrought : MonoBehaviour {

    public Material themeet, themeon, themetw, themeth, themefo, themefi, themesi, themese, themeei;

    private void Start()
    {
        if(PlayerPrefs.GetString("WhatTheme") == "ThemeEtalon"){
            RenderSettings.skybox = themeet;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeOne")
        {
            RenderSettings.skybox = themeon;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeTwo")
        {
            RenderSettings.skybox = themetw;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeThree")
        {
            RenderSettings.skybox = themeth;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeFour")
        {
            RenderSettings.skybox = themefo;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeFive")
        {
            RenderSettings.skybox = themefi;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeSix")
        {
            RenderSettings.skybox = themesi;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeSeven")
        {
            RenderSettings.skybox = themese;
        }
        if (PlayerPrefs.GetString("WhatTheme") == "ThemeEight")
        {
            RenderSettings.skybox = themeei;
        }
    }
}
