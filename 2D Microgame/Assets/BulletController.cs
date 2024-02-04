using System.Collections;
using System.Collections.Generic;
using Platformer.Mechanics;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed = 10f;

    public GameObject Player;
    public PlayerController playerController;

    void Start() {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerController = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the bullet horizontally
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(!GetComponent<Renderer>().isVisible){
            Destroy(gameObject);
        }
    }

     void OnCollisionEnter2D(Collision2D collision) {
        
        if (collision.gameObject.CompareTag("Enemy")){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

   
}
