using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public Transform teleportDestination;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Reset")
        {
            movement.enabled = false;
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.EndGame();
        }

        {
            if (collision.gameObject.tag == "Breakable")
            {
                Destroy(collision.gameObject);
            }

            if (collision.gameObject.tag == "Teleport")
            {
                transform.position = teleportDestination.position;
                
            }
            if (collision.gameObject.tag == "Stop")
            {
            Destroy(collision.gameObject);
            movement.enabled = false;
            movement.enabled = true;
            }
        }

    }


    }