using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Кошелёк.
/// </summary>
public static class Wallet
{
    private const int startCoinsCount = 0;

    public static int CoinsCount { get; set; } = startCoinsCount;

    public static void RestartCoins()
    {
        CoinsCount = startCoinsCount;
    }
}
