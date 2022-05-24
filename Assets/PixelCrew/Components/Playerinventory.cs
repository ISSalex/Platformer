using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinventory : MonoBehaviour, IInventory
{
    public int Money { get => _noney; set => _noney = value; }

    public int _noney = 0;

}
