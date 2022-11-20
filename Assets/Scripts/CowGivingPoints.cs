using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowGivingPoints : MonoBehaviour
{
    public static CowGivingPoints obj;
    public int giveMilk;
    public int giveMilkOnClick;

    void Awake()
    {
        obj = this;
    }
    
    void Start()
    {
        InvokeRepeating(nameof(CowIsGivingMilk), 0f, 3f);
        giveMilk = 2;
        giveMilkOnClick = 1;
    }

    void CowIsGivingMilk()
    {
        PointManager.obj.AddScoreMilk(giveMilk);
    }

    public void ClickOnScreenMilk()
    {
        PointManager.obj.AddScoreMilk(giveMilkOnClick);
    }

    void OnDestroy()
    {
        obj = null;
    }
}