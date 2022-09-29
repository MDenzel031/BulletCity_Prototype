using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platforms"))
        {
            GameObject.Find("Player").GetComponent<Animator>().SetBool("isJumping", false);
            Debug.Log("Hell");
        }
    }
}
