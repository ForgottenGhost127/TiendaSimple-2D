using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class PlayerCoins : MonoBehaviour
{
    public int CurrentMoney { get; private set;}

    [SerializeField] private int startingMoney = 600;
    [SerializeField] private TextMeshProUGUI moneyText;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
