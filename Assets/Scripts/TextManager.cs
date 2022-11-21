using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager obj;

    [SerializeField] Text wheatOnScreen;
    [SerializeField] Text milkOnScreen;
    [SerializeField] Text eggsOnScreen;
    [SerializeField] Text applesOnScreen;
    [SerializeField] Text cakesOnScreen;


    void Awake()
    {
        obj = this;
    }

    public void UpdateOnScreen()
    {
        wheatOnScreen.text = "" + PointManager.obj.WheatScore;
        milkOnScreen.text = "" + PointManager.obj.MilkScore;
        eggsOnScreen.text = "" + PointManager.obj.EggScore;
        applesOnScreen.text = "" + PointManager.obj.AppleScore;
        cakesOnScreen.text = "" + PointManager.obj.CakeScore;
    }

    void OnDestroy()
    {
        obj = null;
    }
}