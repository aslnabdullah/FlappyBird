using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    
    //void Start()
    //{
    //    rb2D = GetComponent<Rigidbody2D>();
        
    //}

    void Update()
    {
        //Getting click
        if (Input.GetMouseButtonDown(0))
        {
            //for flying
            rb2D.velocity = Vector2.up * velocity;

        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
        }
    }

}
