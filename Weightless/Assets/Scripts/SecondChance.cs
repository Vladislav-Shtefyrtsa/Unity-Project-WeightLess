using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondChance : MonoBehaviour {

    public GameObject Ball;
    public GameObject Bottom;
    public GameObject defeatWall;
    public GameObject rRight;
    public GameObject lLeft;
    public Rigidbody2D bollz;
    public SpriteRenderer RenderRight;
    public SpriteRenderer RenderLeft;

    private void OnMouseDown()
    {
        Vector3 screenPoz = new Vector3(Screen.width, Screen.height, 0);
        Vector3 worldPoz = Camera.main.ScreenToWorldPoint(screenPoz);
        Ball.transform.position = new Vector3(0, -(worldPoz.y) + 0.90f, 0);
        Bottom.SetActive(true);
        Destroy(defeatWall.gameObject);
        Ball.SetActive(true);
        rRight.SetActive(true);
        lLeft.SetActive(true);
        PlayerPrefs.SetFloat("Flir", 0);
        PlayerPrefs.SetFloat("Flor", 0);
        Ball.transform.rotation = Quaternion.Euler(0, 0, 0);
        bollz.freezeRotation = false;
        RenderLeft.enabled = false;
        RenderRight.enabled = false;
    }
}
