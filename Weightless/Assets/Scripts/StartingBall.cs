using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingBall : MonoBehaviour {

    public SpriteRenderer Ball;
    public SpriteRenderer fakeBall;
    public GameObject fakeBill;
    public Rigidbody2D rgd2d;
    public GameObject Bottom;
    public GameObject Score;
    public GameObject highScore;
    public GameObject buttons;
    public GameObject TTP;

    private void Start()
    {
        Ball.GetComponent<SpriteRenderer>();
        Ball.enabled = false;
        fakeBall.GetComponent<SpriteRenderer>();
        fakeBall.enabled = true;
    }

    private void OnMouseDown()
    {
        Ball.enabled = true;
        fakeBall.enabled = false;
        if (fakeBall.enabled == false){
            Destroy(fakeBill.gameObject);
        }
        rgd2d.velocity = new Vector3(0, 18, 0);
        buttons.SetActive(false);
        highScore.SetActive(false);
        Score.SetActive(true);
        TTP.SetActive(false);
        Bottom.SetActive(false);
    }

}
