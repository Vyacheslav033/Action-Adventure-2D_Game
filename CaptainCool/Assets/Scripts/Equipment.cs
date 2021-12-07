using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Equipment
{
    private int bulletsCount;

    public Equipment(int bulletsCount)
    {
        this.bulletsCount = bulletsCount;
    }

    public int BulletsCount
    {
        get { return bulletsCount; }
        set { bulletsCount = value; }
    }
}
