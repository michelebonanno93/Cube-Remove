using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    int mosse = 0;
    public TextMeshProUGUI contaMosseText;
    public TextMeshProUGUI winText;
    public Button button;

    void OnTriggerEnter2D(Collider2D collision)
    {
     
        if (collision.GetComponent<Collider2D>().CompareTag("Coin"))
        {
            SoundManager.PlaySound("win");
            winText.enabled = true;
            button.gameObject.SetActive(true);
            winText.SetText("VITTORIA IN " + mosse + " mosse");
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
     
        if (collision.gameObject.tag =="Blocks")
        {
            SoundManager.PlaySound("rock");
            mosse++;
            AggiornaMosse();
        } 
    }

    void AggiornaMosse()
    {
        contaMosseText.SetText("MOSSE: " + mosse);
    }
}