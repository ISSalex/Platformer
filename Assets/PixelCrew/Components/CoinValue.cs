using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinValue : MonoBehaviour
{
    [SerializeField] private int _Money;
    private void OnTriggerEnter2D(Collider2D other)
    {
            MoneyCounter._money += _Money;
    }
}
