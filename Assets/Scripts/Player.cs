using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidBody;
    public float velocity = 300;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        GetComponent<Collision>().winText.enabled = false;
        GetComponent<Collision>().button.gameObject.SetActive(false);
    }


    void Update()
    {
        
        float movimentoX = Input.GetAxisRaw("Horizontal") * velocity * Time.deltaTime;
        float movimentoY = Input.GetAxisRaw("Vertical") * velocity * Time.deltaTime;
        rigidBody.velocity = new Vector2(movimentoX, movimentoY);
    }
}
