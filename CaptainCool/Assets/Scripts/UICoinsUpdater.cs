﻿using TMPro;
using UnityEngine;

public class UICoinsUpdater : MonoBehaviour
{
    public TextMeshProUGUI СoinsCountUI;

    private void Update()
    {
        СoinsCountUI.text = CoinCollector.GetCoinsCount().ToString();
    }

}