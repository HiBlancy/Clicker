using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCow : MonoBehaviour
{
    public bool isLocked;
    int priceToUnlock = -10;

    [SerializeField] GameObject cow;

    void Start()
    {
        isLocked = true;
        cow = GetComponent<GameObject>(); //correjir porque no aparece en el inspector una vez iniciado
    }

    public void CowLocked()
    {
        if (PointManager.obj.WheatScore >= 10)
        {
            PointManager.obj.TakeScoreWheat(priceToUnlock);
            isLocked = false;
            cow.GetComponent<CowGivingPoints>().enabled = true;
            gameObject.SetActive(false);
        }
    }
}