using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTreeGivingPoints : MonoBehaviour
{
    public static AppleTreeGivingPoints obj;
    public int giveApples;
    public int giveApplesOnClick = 1;

    void Awake()
    {
        obj = this;
    }

    void Start()
    {
        InvokeRepeating(nameof(TreeIsGivingApples), 0f, 16f);
        giveApples = 14;
    }

    void TreeIsGivingApples()
    {
        PointManager.obj.AddScoreApples(giveApples);
    }

    public void ClickOnScreenApples()
    {
        PointManager.obj.AddScoreApples(giveApplesOnClick);
    }

    void OnDestroy()
    {
        obj = null;
    }
}