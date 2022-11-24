using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleTreeUnlock : MonoBehaviour
{
    public bool isLocked;
    int priceToUnlockWheat = -650;
    int priceToUnlockMilk = -400;
    int priceToUnlockEggs = -320;

    [SerializeField] GameObject appleTree;

    void Start()
    {
        isLocked = true;
        appleTree = GameObject.FindGameObjectWithTag("Tree");
    }

    public void TreeLocked()
    {
        if (PointManager.obj.WheatScore >= 650 & PointManager.obj.MilkScore >= 400 & PointManager.obj.EggScore >= 320)
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