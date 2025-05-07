using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
  
    public void Items()
    {
        SceneManager.LoadScene("Products");
    }

    
    public void Back()
    {
        SceneManager.LoadScene("ItemList");
    }



    public void Inventory()
    {
        SceneManager.LoadScene("Investory");
    }
}