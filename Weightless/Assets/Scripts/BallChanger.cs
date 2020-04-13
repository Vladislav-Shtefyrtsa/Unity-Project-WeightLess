using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChanger : MonoBehaviour {

    private void OnMouseDown()
    {
        PlayerPrefs.SetString("SkinsBall",gameObject.name);
    }
}
