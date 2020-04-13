using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLockers : MonoBehaviour {

    public GameObject lockBeach, lockBoulling, lockCol, lockDark, lockDis, lockEight, lockEye, lockGolf, lockHz, lockLight, lockMeteor, lockNone, lockPlanet, lockPok, lockTenis, lockVoley, lockBasket, lockAim, lockBluesket, lockCandy, lockChristmas, lockDarksket, lockElastic, lockGreen, lockHoles, lockNewsket, lockOrange, lockRedish, lockSnowman, lockSoccer, lockTiger, lockTomato, lockToy, lockWolverine, lockZebra;

	void Start () {
        if(PlayerPrefs.GetString("LockingH").Contains("Beach-Ball")){
            Destroy(lockBeach.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Boulling-Ball"))
        {
            Destroy(lockBoulling.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Col-Ball"))
        {
            Destroy(lockCol.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Dark-Ball"))
        {
            Destroy(lockDark.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Dis-Ball"))
        {
            Destroy(lockDis.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Eight-Ball"))
        {
            Destroy(lockEight.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Eye-Ball"))
        {
            Destroy(lockEye.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Golf-Ball"))
        {
            Destroy(lockGolf.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Hz-Ball"))
        {
            Destroy(lockHz.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Light-Ball"))
        {
            Destroy(lockLight.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Meteor-Ball"))
        {
            Destroy(lockMeteor.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("None-Ball"))
        {
            Destroy(lockNone.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Planet-Ball"))
        {
            Destroy(lockPlanet.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Pok-Ball"))
        {
            Destroy(lockPok.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Tenis-Ball"))
        {
            Destroy(lockTenis.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Voley-Ball"))
        {
            Destroy(lockVoley.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Basket-Ball"))
        {
            Destroy(lockBasket.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Aim-Ball"))
        {
            Destroy(lockAim.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Bluesket-Ball"))
        {
            Destroy(lockBluesket.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Candy-Ball"))
        {
            Destroy(lockCandy.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Christmas-Ball"))
        {
            Destroy(lockChristmas.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Darksket-Ball"))
        {
            Destroy(lockDarksket.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Elastic-Ball"))
        {
            Destroy(lockElastic.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Green-Ball"))
        {
            Destroy(lockGreen.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Holes-Ball"))
        {
            Destroy(lockHoles.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Newsket-Ball"))
        {
            Destroy(lockNewsket.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Orange-Ball"))
        {
            Destroy(lockOrange.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Redish-Ball"))
        {
            Destroy(lockRedish.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Snowman-Ball"))
        {
            Destroy(lockSnowman.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Soccer-Ball"))
        {
            Destroy(lockSoccer.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Tiger-Ball"))
        {
            Destroy(lockTiger.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Tomato-Ball"))
        {
            Destroy(lockTomato.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Toy-Ball"))
        {
            Destroy(lockToy.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Wolverine-Ball"))
        {
            Destroy(lockWolverine.gameObject);
        }
        if (PlayerPrefs.GetString("LockingH").Contains("Zebra-Ball"))
        {
            Destroy(lockZebra.gameObject);
        }
    }
}
