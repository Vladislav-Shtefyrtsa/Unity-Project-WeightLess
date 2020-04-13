using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnMouse : MonoBehaviour {

    public AudioSource sound;

    private void OnMouseDown()
    {
        sound.Play(0);
    }
}
