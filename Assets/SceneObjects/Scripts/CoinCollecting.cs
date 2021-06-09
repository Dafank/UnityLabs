using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollecting : MonoBehaviour
{

    public Text countText, coinsLeft;
    private int count;
    private int countCoins;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        countText.text = "";
        coinsLeft.text = "";
        coinsLeft.text = "";
        countCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
        SetCount();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin") 
        {
            Destroy(other.gameObject);
            count++;
            SetCount();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetCount()
    {
        countText.text = "Кількість: " + count.ToString();
        coinsLeft.text = "Залишилось: " + (countCoins - count).ToString() + " монет";
    }
}
