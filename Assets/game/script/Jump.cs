using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    private float jumpForce;
    void Start()
    {
        if (gameObject.CompareTag("Trampoline")) jumpForce = 1200f;
        else jumpForce = 800f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool is_down = collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0;

        bool is_player = collision.gameObject.CompareTag("Player");
        
        if (is_down && is_player)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
            musicControl.insMusic.Audio.PlayOneShot(musicControl.insMusic.jump);
        }


    }
}
