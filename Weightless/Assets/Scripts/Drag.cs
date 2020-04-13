using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {

    public GameObject Balls;
    bool startPos = true;
    float startPoz;
    float startBall;
    bool Limits = false;
    void OnMouseDrag()
    {

        if (Limits == true)
        {
            if (Input.touchCount > 0)
            {
            Vector3 screenPos = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 10);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                if (startPos == true)
                {
                    startPoz = worldPos.y;
                    startPos = false;
                    startBall = Balls.transform.position.y;
                }
                if (Balls.activeSelf == true)
                {
                    Balls.transform.position = new Vector3(Balls.transform.position.x, startBall + (worldPos.y - startPoz), Balls.transform.position.z);
                }
            }
        }
    }

    private void OnMouseUp()
    {
        startPos = true;
    }

    private void Update()
    {
        if(Balls.transform.position.y >= 0f && Balls.transform.position.y <= 15.5f && Limits == false){
            Limits = true;
        }
        if (Balls.transform.position.y < 0f  && Limits == true)
        {
            Limits = false;
            Balls.transform.position = new Vector3(Balls.transform.position.x,0,Balls.transform.position.z);
        }
        if (Balls.transform.position.y > 15.5f && Limits == true)
        {
            Limits = false;
            Balls.transform.position = new Vector3(Balls.transform.position.x, 15.48f, Balls.transform.position.z);
        }
    }
}
