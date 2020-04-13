using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinThrought : MonoBehaviour {

    public GameObject Ball;
    public GameObject fakeBall;
    public Sprite FootBall, BeachBall, BoullingBall, ColBall, DarkBall, DisBall, EightBall, EyeBall, GolfBall, HzBall, LightBall, MeteorBall, NoneBall, PlanetBall, PokBall, TenisBall, VoleyBall, BasketBall, AimBall, BluesketBall, CandyBall, ChristmasBall, DarksketBall, ElasticBall, GreenBall, HolesBall, NewsketBall, OrangeBall, RedishBall, SnowmanBall, SoccerBall, TigerBall, TomatoBall, ToyBall, WolverineBall, ZebraBall;

    void Update () {
        if (PlayerPrefs.GetString("SkinsBall") == "foot-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = FootBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = FootBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Beach-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = BeachBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = BeachBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Boulling-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = BoullingBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = BoullingBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Col-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = ColBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = ColBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Dark-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = DarkBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = DarkBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Dis-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = DisBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = DisBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Eight-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = EightBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = EightBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Eye-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = EyeBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = EyeBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Golf-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = GolfBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = GolfBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Hz-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = HzBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = HzBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Light-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = LightBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = LightBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Meteor-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = MeteorBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = MeteorBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "None-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = NoneBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = NoneBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Planet-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = PlanetBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = PlanetBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Pok-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = PokBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = PokBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Tenis-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = TenisBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = TenisBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Voley-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = VoleyBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = VoleyBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Basket-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = BasketBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = BasketBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Aim-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = AimBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = AimBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Bluesket-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = BluesketBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = BluesketBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Candy-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = CandyBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = CandyBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Christmas-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = ChristmasBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = ChristmasBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Darksket-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = DarksketBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = DarksketBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Elastic-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = ElasticBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = ElasticBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Green-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = GreenBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = GreenBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Holes-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = HolesBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = HolesBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Newsket-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = NewsketBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = NewsketBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Orange-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = OrangeBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = OrangeBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Redish-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = RedishBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = RedishBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Snowman-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = SnowmanBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = SnowmanBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Soccer-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = SoccerBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = SoccerBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Tiger-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = TigerBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = TigerBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Tomato-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = TomatoBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = TomatoBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Toy-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = ToyBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = ToyBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Wolverine-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = WolverineBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = WolverineBall;
            }
        }
        if (PlayerPrefs.GetString("SkinsBall") == "Zebra-Ball")
        {
            Ball.GetComponent<SpriteRenderer>().sprite = ZebraBall;
            if (fakeBall != null)
            {
                fakeBall.GetComponent<SpriteRenderer>().sprite = ZebraBall;
            }
        }
    }
}
