using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace InventorySystem
{
    public class InventorySystem : MonoBehaviour
    {
        static List<string> inventory = new List<string>();

        public TMP_InputField itemInput;
        public TMP_InputField itemInputRemove;
        public TextMeshProUGUI addText;
        public TextMeshProUGUI removeText;
        public string item;

        public TextMeshProUGUI displayItems;

        public void AdditionofItem()
        {
            item = itemInput.text;
            inventory.Add(item);
            addText.text = ($"Added {item}!");
        }

        public void ItemRemoval()
        {
            item = itemInputRemove.text;
            inventory.Remove(item);
            removeText.text = ($"Removed {item}!");
        }

        public void ShowInventory()
        {
            string allItems = "";
            foreach (var item in inventory)
            {
                allItems += item + "\n";
            }
            displayItems.text = allItems;
        }

        public void Start()
        {
            ShowInventory();
        }
    }
}