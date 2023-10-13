using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumOfCoins { get; private set; }

   public UnityEvent<PlayerInventory> OnCoinsCollected;

   public void CoinsCollected()
   {
    NumOfCoins++;
    OnCoinsCollected.Invoke(this);
   }
}
