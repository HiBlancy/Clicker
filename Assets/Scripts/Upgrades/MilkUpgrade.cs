using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MilkUpgrade : MonoBehaviour
{
    [SerializeField] Text upgradeTextWheat;
    [SerializeField] Text upgradeTextMilk;
    [SerializeField] Text upgardeTextEggs;
    [SerializeField] Text upgradeTextApples;

    int upgradeWheat = 50;
    int upgradeMilk = 15;
    int upgradeEggs;
    int upgradeApples;
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

            CowGivingPoints.obj.giveMilkOnClick += 4;

            upgradeWheat += 14;
            upgradeMilk += 41;
            upgradeEggs += 60;
            upgradeApples += 80;

            TextManager.obj.UpdateOnScreen();
        }
    }
}