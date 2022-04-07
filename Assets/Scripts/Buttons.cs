using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Gioca()
    {
        Debug.Log("Caricamento Livello 1");
        SceneManager.LoadScene(1);
    }

    public void Esci()
    {
    }

    public void Successivo()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
