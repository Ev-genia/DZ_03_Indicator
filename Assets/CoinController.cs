using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    public GameObject TextObject;
    Text textComponent;

    void Start()
    {
        textComponent = TextObject.GetComponent<Text>();
    }

    public int Coin = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Coin = Coin + 1;
            textComponent.text = Coin.ToString();
            Debug.Log($"Coins: {Coin}");
        }
    }
}
