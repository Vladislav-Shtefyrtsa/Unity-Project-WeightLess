using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSwitcher : MonoBehaviour {

    public GameObject one;
    public GameObject two;

    private void OnMouseDown()
    {
        two.SetActive(true);
        one.SetActive(false);
    }
}
