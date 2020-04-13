using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOn : MonoBehaviour {

    public GameObject thisWindow;

	void OnMouseDown() {
        thisWindow.SetActive(true);
	}
}
