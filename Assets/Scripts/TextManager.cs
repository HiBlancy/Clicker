using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public static TextManager obj;

    [SerializeField] Text wheatOnScreen;
    [SerializeField] Text milkOnScreen;

    void Awake()
    {
        obj = this;
    }

    public void UpdateOnScreen()
    {
        wheatOnScreen.text = "" + PointManager.obj.WheatScore;
        milkOnScreen.text = "" + PointManager.obj.MilkScore;
    }

    void OnDestroy()
    {
        obj = null;
    }
}