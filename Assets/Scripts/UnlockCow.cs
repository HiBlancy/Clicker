using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockCow : MonoBehaviour
{
    public bool isLocked;
    int priceToUnlock = -10;

    [SerializeField] GameObject cow;

    void Start()
    {
        isLocked = true;
        cow = GameObject.FindGameObjectWithTag("Cow");
    }

    public void CowLocked()
    {
        if (PointManager.obj.WheatScore >= 10)
        {
            PointManager.obj.TakeScoreWheat(priceToUnlock);
            isLocked = false;
            cow.GetComponent<CowGivingPoints>().enabled = true;
            cow.GetComponent<Button>().enabled = true;
            gameObject.SetActive(false);
        }
    }
}