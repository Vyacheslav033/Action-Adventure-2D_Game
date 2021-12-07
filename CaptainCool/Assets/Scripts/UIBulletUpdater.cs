using TMPro;
using UnityEngine;

public class UIBulletUpdater : MonoBehaviour
{
    public TextMeshProUGUI BulletsCountUI;

    private void Update()
    {
        BulletsCountUI.text = Weapon.GetBulletsCount().ToString();
    }

}
