using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public Text moneyText;
    public int money;
    public int earnedMoney;

    private void Start()
    {
        money =PlayerPrefs.GetInt("Money");
        earnedMoney= PlayerPrefs.GetInt("Score");
        money += earnedMoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();
        earnedMoney = 0;
        PlayerPrefs.SetInt("Score",earnedMoney);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


}
