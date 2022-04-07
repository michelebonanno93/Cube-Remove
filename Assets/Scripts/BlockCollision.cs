using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCollision : MonoBehaviour
{
    public Rigidbody2D rigid;

    public float distance;
    RaycastHit2D hitUp;
    RaycastHit2D hitDown;
    RaycastHit2D hitLeft;
    RaycastHit2D hitRight;

    void OnCollisionEnter2D(Collision2D collision){

        distance = 5f;
        hitUp = Physics2D.Raycast(transform.position, Vector2.up);
        hitDown = Physics2D.Raycast(transform.position, -Vector2.up);
        hitLeft = Physics2D.Raycast(transform.position, Vector2.left);
        hitRight = Physics2D.Raycast(transform.position, -Vector2.left);

        rigid = collision.gameObject.GetComponent<Rigidbody2D>();

       if (hitUp.collider != null) {
           Debug.Log("UP: " +hitUp.collider.gameObject.name);
       }
       if (hitDown.collider != null ) {
           Debug.Log("DOWN: " +hitDown.collider.gameObject.name);
       }
       if (hitLeft.collider != null) {
           Debug.Log("LEFT: " +hitLeft.collider.gameObject.name);
       }
       if (hitRight.collider != null) {
           Debug.Log("RIGHT: " +hitRight.collider.gameObject.name);
       }

        if (collision.gameObject.tag == "Blocks"){
            //rigid.bodyType = RigidbodyType2D.Static;
            Debug.DrawRay(transform.position, -collision.contacts[0].normal, Color.red, 1, false);

            Debug.DrawRay(collision.gameObject.transform.position, collision.contacts[0].normal, Color.blue, 1, false);
        }
        Debug.DrawRay(transform.position, Vector2.up, Color.green, 1);
        Debug.DrawRay(transform.position, Vector2.down, Color.grey, 1);
        Debug.DrawRay(transform.position, Vector2.left, Color.magenta, 1);
        Debug.DrawRay(transform.position, Vector2.right, Color.white, 1);
    }
}
