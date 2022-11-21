using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggUpgrade : MonoBehaviour
{
    [SerializeField] Text upgradeTextWheat;
    [SerializeField] Text upgradeTextMilk;
    [SerializeField] Text upgardeTextEggs;
    [SerializeField] Text upgradeTextApples;

    int upgradeWheat = 80;
    int upgradeMilk = 25;
    int upgradeEggs = 12;
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

            upgradeWheat += 20;
            upgradeMilk += 51;
            upgradeEggs += 68;
            upgradeApples += 90;

            TextManager.obj.UpdateOnScreen();
        }
    }
}
