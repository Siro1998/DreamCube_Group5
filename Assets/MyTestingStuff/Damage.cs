using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    GameManager gameManager;
    private Collider m_Collider;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        m_Collider = GetComponent<Collider>();
        StartCoroutine(ExampleCoroutine());
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball")) {
            DamagePlayer();
        }
    }
    void DamagePlayer()
    {
        gameManager._healthController.playerHealth = gameManager._healthController.playerHealth - 1; //bombDamage;
        Debug.Log(gameManager._healthController.playerHealth);
        
        var demoScene = GameObject.FindObjectOfType<DemoSceneManager>();
        if(gameManager._healthController.playerHealth<1)
        {
            demoScene.LoadSceneWithIndex(0); 
        }
        gameManager._healthController.UpdateHealth();
        //gameObject.SetActive(false);
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);
        m_Collider.enabled = !m_Collider.enabled;
    }
}
