using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollPos : MonoBehaviour {

    public GameObject collLeft;
    public GameObject collRight;
    public GameObject collBottom;
    public GameObject collBottomTwo;
    public GameObject fakeBall;
    public GameObject fakeFakeBall;

    void Start () {
        Vector3 screenPoz = new Vector3(Screen.width, Screen.height, 0);
        Vector3 worldPoz = Camera.main.ScreenToWorldPoint(screenPoz);
        collLeft.transform.position = new Vector3(0-(worldPoz.x),0,0);
        collRight.transform.position = new Vector3(0 + (worldPoz.x), 0, 0);
        collBottom.transform.position = new Vector3(0,0-(worldPoz.y), 0);
        collBottomTwo.transform.position = new Vector3(0, 0 - (worldPoz.y) - 5.0f, 0);
        fakeBall.transform.position = new Vector3(0,-(worldPoz.y)+0.90f,0);
        fakeFakeBall.transform.position = new Vector3(0, -(worldPoz.y) + 0.90f, -1);
    }
}
