using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleUpgrade : MonoBehaviour
{
    [SerializeField] Text upgradeTextWheat;
    [SerializeField] Text upgradeTextMilk;
    [SerializeField] Text upgardeTextEggs;
    [SerializeField] Text upgradeTextApples;

    int upgradeWheat = 100;
    int upgradeMilk = 55;
    int upgradeEggs = 32;
    int upgradeApples = 12;

    void Update()
    {
        upgradeTextWheat.text = "" + upgradeWheat;
        upgradeTextMilk.text = "" + upgradeMilk;
        upgardeTextEggs.text = "" + upgradeEggs;
        upgradeTextApples.text = "" + upgradeApples;
    }

    public void Upgrade()
    {
        if (PointManager.obj.WheatScore >= upgradeWheat & PointManager.obj.MilkScore >= upgradeMilk & PointManager.obj.EggScore >= upgradeEggs & PointManager.obj.AppleScore >= upgradeApples)
        {
            PointManager.obj.WheatScore -= upgradeWheat;
            PointManager.obj.MilkScore -= upgradeMilk;
            PointManager.obj.EggScore -= upgradeEggs;
            PointManager.obj.AppleScore -= upgradeApples;

            AppleTreeGivingPoints.obj.giveApplesOnClick += 7;

            upgradeWheat += 70;
            upgradeMilk += 81;
            upgradeEggs += 98;
            upgradeApples += 120;

            TextManager.obj.UpdateOnScreen();
        }
    }
}