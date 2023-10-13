using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI InventoryText;
    // Start is called before the first frame update
    void Start()
    {
        InventoryText = GetComponent<TextMeshProUGUI>();
    }
    public void updateInvetoryText(PlayerInventory playerInventory)
    {
        InventoryText.text = playerInventory.NumOfCoins.ToString();
    }
}
