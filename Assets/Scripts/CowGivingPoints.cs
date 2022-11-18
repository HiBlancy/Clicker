using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowGivingPoints : MonoBehaviour
{
    public static CowGivingPoints obj;
    public int giveMilk = 2;

    void Awake()
    {
        obj = this;
    }
    
    void Start()
    {
        InvokeRepeating("CowIsGivingMilk", 0f, 3f);
    }

    void CowIsGivingMilk()
    {
        PointManager.obj.AddScoreMilk(giveMilk);
    }

    void OnDestroy()
    {
        obj = null;
    }
}
