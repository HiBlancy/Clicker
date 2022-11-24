using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChikenUnlock : MonoBehaviour
{
    public bool isLocked;
    int priceToUnlockWheat = -100;
    int priceToUnlockMilk = -85;

    [SerializeField] GameObject chiken;

    void Start()
    {
        isLocked = true;
        chiken = GameObject.FindGameObjectWithTag("Chiken");
    }

    public void ChikenLocked()
    {
        if (PointManager.obj.WheatScore >= 100 & PointManager.obj.MilkScore >= 85)
        {
            PointManager.obj.TakeScoreWheat(priceToUnlockWheat);
            PointManager.obj.TakeScoreMilk(priceToUnlockMilk);
            isLocked = false;
            chiken.GetComponent<ChikenGivingPoints>().enabled = true;
            chiken.GetComponent<Button>().enabled = true;
            gameObject.SetActive(false);
        }
    }
}