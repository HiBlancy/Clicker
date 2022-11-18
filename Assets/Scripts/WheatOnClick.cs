using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatOnClick : MonoBehaviour
{
    public static WheatOnClick obj;
    public int giveWheat = 1;

    void Awake()
    {
        obj = this;
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