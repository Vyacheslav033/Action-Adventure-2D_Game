using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Снаряжение.
/// </summary>
public static class Equipment
{
    private const int startBulletsCount = 20;

    public static int BulletsCount { get; set; } = startBulletsCount;

    public static void RestartBullets()
    {
        BulletsCount = startBulletsCount;
    }

}
