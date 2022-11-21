using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager obj;

    public int WheatScore;
    public int MilkScore;
    public int EggScore;
    public int AppleScore;
    public int CakeScore;

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
    public void TakeScoreMilk(int priceToUnlock)
    {
        MilkScore += priceToUnlock;
        TextManager.obj.UpdateOnScreen();
    }
    public void AddScoreEggs(int giveEggs)
    {
        EggScore += giveEggs;
        TextManager.obj.UpdateOnScreen();
    }
    public void TakeScoreEggs(int priceToUnlock)
    {
        EggScore += priceToUnlock;
        TextManager.obj.UpdateOnScreen();
    }
    public void AddScoreApples(int giveApples)
    {
        AppleScore += giveApples;
        TextManager.obj.UpdateOnScreen();
    }
    public void TakeScoreApples(int priceToUnlock)
    {
        AppleScore += priceToUnlock;
        TextManager.obj.UpdateOnScreen();
    }

    public void AddScoreCakes(int giveCakes)
    {
        CakeScore += giveCakes;
        TextManager.obj.UpdateOnScreen();
    }
    void OnDestroy()
    {
        obj = null;
    }
}