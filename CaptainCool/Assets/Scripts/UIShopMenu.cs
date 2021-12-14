using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopMenu : MonoBehaviour
{
    private const int oneBulletPrice = 10;

    public void BuyEquipment()
    {
        if (CoinCollector.CoinsCount >=  oneBulletPrice)
        {
            CoinCollector.CoinsCount -= oneBulletPrice;
            Equipment.BulletsCount++;
        }
    }
}
