using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public float bounceForce = 10f;
    public int damage = 1; // jangan pakai '1f' untuk int

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tambahkan kurung pada CompareTag
        if (collision.gameObject.CompareTag("Player"))
        {
            HandPlayerBounce(collision.gameObject);

            // Tambahkan pemanggilan fungsi Die() jika ingin pemain mati
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            if (player != null)
            {
                player.Die();
            }
        }
    }

    private void HandPlayerBounce(GameObject player)
    {
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Perbaikan penulisan titik (rb.velocity.x.)
            rb.velocity = new Vector2(rb.velocity.x, 0f);

            // apply bounce force
            rb.AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}
