using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressToJump : MonoBehaviour {

    Rigidbody2D rgd2d;
    int ballpos = 0;
    public int score = 0;
    public Text scoreText;
    public Text highScore;
    public GameObject newScoreAnim;

    private void Start()
    {
        rgd2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && ballpos == 1)
        {
            rgd2d.velocity = new Vector3(0, 18, 0);
        }
        scoreText.text = score.ToString();
        highScore.text = "HIGH SCORE : " + PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    private void OnMouseDown()
    {
        StartCoroutine(Cors());
        score = score + 1;
        if(score > PlayerPrefs.GetInt("HighScore",0)){
            PlayerPrefs.SetInt("HighScore", score);
            newScoreAnim.SetActive(true);
        }
    }

    IEnumerator Cors(){
        ballpos = 1;
        yield return new WaitForSeconds(0.01f);
        ballpos = 0;
    }
}
