using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetOff : MonoBehaviour {

    public GameObject Bottom;

    private void OnMouseDown()
    {
        if(Bottom.activeSelf){
            Bottom.SetActive(false);
        }
    }
}
