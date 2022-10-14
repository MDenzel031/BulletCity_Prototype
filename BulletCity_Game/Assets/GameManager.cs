using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI coins;
    public GameObject player;
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

    public void playerDeath()
    {
        audioManager.playSound("waterSplash");
        audioManager.playSound("deathSound");
        player.SetActive(false);
        Invoke(nameof(resetLevel), 2.0f);
    }

    public void playerDeathByEnemy()
    {
        audioManager.playSound("deathSound");
        Invoke(nameof(resetLevel), 2.0f);
    }


    private int getCurrentCoins()
    {
        int currentCoins = int.Parse(coins.text);
        return currentCoins;
    }

    private void resetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
