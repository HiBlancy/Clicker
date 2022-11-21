using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatOnClick : MonoBehaviour
{
    public static WheatOnClick obj;
    public static int giveWheat;

    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        giveWheat = 2;
    }

    public void ClickOnScreenWheat()
    {
        PointManager.obj.AddScoreWheat(giveWheat);
    }

    void OnDestroy()
    {
        obj = null;
    }
}