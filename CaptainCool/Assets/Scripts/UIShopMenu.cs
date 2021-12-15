using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShopMenu : MonoBehaviour
{
    private const int oneBulletPrice = 25;

    public void BuyEquipment()
    {
        if (Wallet.CoinsCount >=  oneBulletPrice)
        {
            Wallet.CoinsCount -= oneBulletPrice;
            Equipment.BulletsCount++;
        }
    }
}
