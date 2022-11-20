using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTreeUnlock : MonoBehaviour
{
    public bool isLocked;
    int priceToUnlockWheat = -320;
    int priceToUnlockMilk = -400;
    int priceToUnlockEggs = -650;

    [SerializeField] GameObject appleTree;

    void Start()
    {
        isLocked = true;
        appleTree = GameObject.FindGameObjectWithTag("Tree");
    }

    public void ChikenLocked()
    {
        if (PointManager.obj.WheatScore >= 320 & PointManager.obj.MilkScore >= 400 & PointManager.obj.EggScore >= 650)
        {
            PointManager.obj.TakeScoreWheat(priceToUnlockWheat);
            PointManager.obj.TakeScoreMilk(priceToUnlockMilk);
            PointManager.obj.TakeScoreEggs(priceToUnlockEggs);
            isLocked = false;
            appleTree.GetComponent<AppleTreeGivingPoints>().enabled = true;
            appleTree.GetComponent<Button>().enabled = true;
            gameObject.SetActive(false);
        }
    }
}