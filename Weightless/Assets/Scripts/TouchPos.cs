using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPos : MonoBehaviour {

    public GameObject Ball;
    int ballpos = 0;
    Rigidbody2D rgd2d;
    public GameObject wallRight;
    public GameObject wallLeft;
    public SpriteRenderer spriteRendererLeft;
    public SpriteRenderer spriteRendererRight;

    private void Start()
    {
        rgd2d = GetComponent<Rigidbody2D>();
        spriteRendererLeft.GetComponent<SpriteRenderer>();
        spriteRendererLeft.enabled = false;
        spriteRendererRight.GetComponent<SpriteRenderer>();
        spriteRendererRight.enabled = false;
        PlayerPrefs.SetFloat("Flir", 0);
        PlayerPrefs.SetFloat("Flor", 0);
    }

    void Update()
    {
        if (Input.touchCount > 0 && ballpos == 1)
        {
            Vector3 screenPos = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 10);
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            if(worldPos.x > Ball.transform.position.x){
                if (worldPos.x < Ball.transform.position.x + 0.55f)
                {
                    float flor = worldPos.x - Ball.transform.position.x;
                    PlayerPrefs.SetFloat("Flor", flor);
                    rgd2d.AddForce(new Vector2(flor * -12000f, 0));
                }
                if (worldPos.x > Ball.transform.position.x + 0.55f)
                {
                    float flor = worldPos.x - Ball.transform.position.x;
                    PlayerPrefs.SetFloat("Flor", flor);
                    rgd2d.AddForce(new Vector2(flor * -7000f, 0));
                }
            }
            if (worldPos.x < Ball.transform.position.x)
            {
                if (worldPos.x > Ball.transform.position.x - 0.55f)
                {
                    float flir = Ball.transform.position.x - worldPos.x;
                    PlayerPrefs.SetFloat("Flir", flir);
                    rgd2d.AddForce(new Vector2(flir * 12000f, 0));
                }
                if (worldPos.x < Ball.transform.position.x - 0.55f)
                {
                    float flir = Ball.transform.position.x - worldPos.x;
                    PlayerPrefs.SetFloat("Flir", flir);
                    rgd2d.AddForce(new Vector2(flir * 7000f, 0));
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name == "Left"){
            rgd2d.AddForce(new Vector2(PlayerPrefs.GetFloat("Flor") * 9000f, 0));
            spriteRendererLeft.enabled = true;
        }
        if (coll.gameObject.name == "Right")
        {
            rgd2d.AddForce(new Vector2(PlayerPrefs.GetFloat("Flir") * -9000f, 0));
            spriteRendererRight.enabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Left")
        {
            spriteRendererLeft.enabled = false;
        }
        if (coll.gameObject.name == "Right")
        {
            spriteRendererRight.enabled = false;
        }
    }


    private void OnMouseDown()
    {
        StartCoroutine(Cors());
    }

    IEnumerator Cors()
    {
        ballpos = 1;
        yield return new WaitForSeconds(0.01f);
        ballpos = 0;
    }
}
