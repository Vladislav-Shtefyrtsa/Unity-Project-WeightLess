using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

    public GameObject defeatWall;
    public GameObject rRight;
    public GameObject lLeft;
    public Rigidbody2D bollz;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "BottomTwo" && defeatWall != null)
        {
            defeatWall.SetActive(true);
            lLeft.SetActive(false);
            rRight.SetActive(false);
            bollz.freezeRotation = true;
        }
        if(coll.gameObject.name == "BottomTwo" && defeatWall == null){
            SceneManager.LoadScene(0);
        }
    }
}
