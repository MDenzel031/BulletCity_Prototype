using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI coins;
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        audioManager.playSound("bgMusic");

    }
    public void addSingleCoin()
    {
        int currentCoins = getCurrentCoins();
        currentCoins++;

        coins.text = currentCoins.ToString();
        audioManager.playSound("coinSound");

    }

    public void addAmountToCoins(int amount)
    {
        int currentCoins = getCurrentCoins();
        currentCoins += amount;
        coins.text = currentCoins.ToString();

        audioManager.playSound("coinSound");
    }

    private int getCurrentCoins()
    {
        int currentCoins = int.Parse(coins.text);
        return currentCoins;
    }
}
