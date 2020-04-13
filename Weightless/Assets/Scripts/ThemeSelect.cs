using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSelect : MonoBehaviour {

    public Material skyetal;

    private void OnMouseDown()
    {
        PlayerPrefs.SetString("WhatTheme",gameObject.name);
        RenderSettings.skybox = skyetal;
    }
}
