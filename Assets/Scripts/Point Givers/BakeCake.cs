using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BakeCake : MonoBehaviour
{
    [SerializeField] Text makeWithTextWheat;
    [SerializeField] Text makeWithTextMilk;
    [SerializeField] Text makeWithTextEggs;
    [SerializeField] Text makeWithTextApples;
    [SerializeField] Text cakesDone;

    readonly int priceToCreatekWheat = 6850;
    readonly int priceToCreateMilk = 4700;
    readonly int priceToCreateEggs = 3500;
    readonly int priceToCreateApples = 2300;

    int cakes;

    void Start()
    {
        makeWithTextWheat.text = "" + priceToCreatekWheat;
        makeWithTextMilk.text = "" + priceToCreateMilk;
        makeWithTextEggs.text = "" + priceToCreateEggs;
        makeWithTextApples.text = "" + priceToCreateApples;
    }

    void FixedUpdate()
    {
        cakesDone.text = "" + cakes;
    }

    public void CreatingCake()
    {
        if (PointManager.obj.WheatScore >= priceToCreatekWheat & PointManager.obj.MilkScore >= priceToCreateMilk 
            & PointManager.obj.EggScore >= priceToCreateEggs & PointManager.obj.AppleScore >= priceToCreateApples)
        {
            PointManager.obj.WheatScore -= priceToCreatekWheat;
            PointManager.obj.MilkScore -= priceToCreateMilk;
            PointManager.obj.EggScore -= priceToCreateEggs;
            PointManager.obj.AppleScore -= priceToCreateApples;

            TextManager.obj.UpdateOnScreen();
            cakes++;
        }
    }
}