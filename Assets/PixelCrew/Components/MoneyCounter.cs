using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class MoneyCounter : MonoBehaviour
{
    public static int _money;

    private void Start()
    {
        _money = 0;
    }

    private void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = _money.ToString();
    }
}
