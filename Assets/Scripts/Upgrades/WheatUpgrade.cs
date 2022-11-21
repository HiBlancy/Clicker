using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheatUpgrade : MonoBehaviour
{
    [SerializeField] Text upgradeTextWheat;
    [SerializeField] Text upgradeTextMilk;
    [SerializeField] Text upgardeTextEggs;
    [SerializeField] Text upgradeTextApples;

    int upgradeWheat = 20;
    int upgradeMilk;
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

            WheatOnClick.giveWheat += 4;

            upgradeWheat += 8;
            upgradeMilk += 37;
            upgradeEggs += 58;
            upgradeApples += 72;

            TextManager.obj.UpdateOnScreen();
        }
    }
}