using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikenGivingPoints : MonoBehaviour
{
    public static ChikenGivingPoints obj;
    public int giveEggs;
    public int giveEggsOnClick = 1;

    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        InvokeRepeating(nameof(ChikenIsGivingEggs), 0f, 6f);
        giveEggs = 3;
    }

    void ChikenIsGivingEggs()
    {
        PointManager.obj.AddScoreEggs(giveEggs);
    }

    public void ClickOnScreenEggs()
    {
        PointManager.obj.AddScoreEggs(giveEggsOnClick);
    }

    void OnDestroy()
    {
        obj = null;
    }
}