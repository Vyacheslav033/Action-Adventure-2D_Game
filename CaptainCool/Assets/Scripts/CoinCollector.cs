using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private static int coinsCount;

    private void Start()
    {
        coinsCount = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            coinsCount++;
        }
    }

    public static int CoinsCount { get => coinsCount; set => coinsCount = value; }
}
