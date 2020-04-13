using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject coin;
    int unt = 0;
    public GameObject buttons;

    private void Update()
    {
        if (unt == 0 && buttons.activeSelf == false)
        {
            StartCoroutine(Corig());
            unt = 1;
        }
    }

    IEnumerator Corig(){
        yield return new WaitForSeconds(4);
        while (true)
        {
                Vector3 screenPos = new Vector3(Screen.width, Screen.height, 0);
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                GameObject clone = Instantiate(coin, new Vector3(Random.Range(0.5f + (-worldPos.x), worldPos.x - 0.5f), Random.Range(0.5f + (-worldPos.y), worldPos.y - 0.5f), 0), Quaternion.identity);
                yield return new WaitForSeconds(3);
                Destroy(clone.gameObject);
                yield return new WaitForSeconds(Random.Range(5f, 10f));
        }
    }
}
