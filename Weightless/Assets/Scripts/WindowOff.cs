using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowOff : MonoBehaviour {

    public GameObject thisWindow;

	void OnMouseDown() {
        thisWindow.SetActive(false);
	}
}
