using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    GameManager gameManager;
    int heartnum;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        heartnum = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter (Collision collision)
    {
       // if(collision.CompareTag("player"))
        if (collision.gameObject.CompareTag("Ball")) {
            // Kill the player
            DamagePlayer();
            //Damage();
        }
    }
    void DamagePlayer()
    {
        //heartnum-=1;
        Debug.Log(heartnum);
        Debug.Log(gameManager._healthController);
        

        gameManager._healthController.playerHealth = gameManager._healthController.playerHealth - 1; //bombDamage;
        // if(gameManager._healthController.playerHealth<1)
        // {
        //     playerMovement.Die();   
        // }
        gameManager._healthController.UpdateHealth();
        //gameObject.SetActive(false);
    }
}
