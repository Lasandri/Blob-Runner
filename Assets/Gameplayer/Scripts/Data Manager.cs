using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    [Header("Coin Texts")]
    [SerializeField] private Text[] coinTexts;
    private int coins;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        coins = PlayerPrefs.GetInt("coins",0);
    }


    // Start is called before the first frame update
    void Start()
    {
        UpdateCoinsTexts();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateCoinsTexts()
    {
        foreach (Text coinText in coinTexts)
        {
            coinText.text = coins.ToString();
        }
    }

    public void AddCoins(int amount)
    {
        coins += amount;

        UpdateCoinsTexts();

        PlayerPrefs.SetInt  ("coins", coins);
    }


}
