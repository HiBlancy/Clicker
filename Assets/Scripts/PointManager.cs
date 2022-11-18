using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager obj;

    public int WheatScore;
    public int MilkScore;

    void Awake()
    {
        obj = this;
    }

    public void AddScoreWheat(int giveWheat)
    {
        WheatScore += giveWheat;
        TextManager.obj.UpdateOnScreen();
    }

    public void TakeScoreWheat(int priceToUnlock)
    {
        WheatScore += priceToUnlock;
        TextManager.obj.UpdateOnScreen();
    }

    public void AddScoreMilk(int giveMilk)
    {
        MilkScore += giveMilk;
        TextManager.obj.UpdateOnScreen();
    }
    public void TakeScoreMilk(int giveMilk)
    {
        MilkScore += giveMilk;
        TextManager.obj.UpdateOnScreen();
    }

    void OnDestroy()
    {
        obj = null;
    }
}