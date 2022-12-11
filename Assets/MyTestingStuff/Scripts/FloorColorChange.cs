using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColorChange : MonoBehaviour
{
    public AudioSource audioSource;
    private bool hasvisited = false;
    //[SerializeField] GameObject coinPrefab;
    //[SerializeField] GameObject obstaclePrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
       //SpawnCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter (Collider collision)
    {
       if (!enabled) return;
       if (collision.gameObject.CompareTag("Ball") && !hasvisited){
            GameManager.inst.IncrementScore(10);
            // Get the Renderer component from the new cube
            var cubeRenderer = gameObject.GetComponent<Renderer>();
            // Create a new RGBA color using the Color constructor and store it in a variable
            //Color customColor = new Color(0.4f, 0.9f, 0.7f, 1.0f);
            // Call SetColor using the shader property name "_Color" and setting the color to red
            //cubeRenderer.material.SetColor("_Color", customColor);
            cubeRenderer.material.color = Color.white;
            //gameObject.tag = "BlockOnCollide";
            audioSource.Play();
            hasvisited = true;
        }
    }
    // private void OnTriggerExit (Collider collision)
    // {
    //    if (!enabled) return;
    //    if (collision.gameObject.CompareTag("Ball")){
    //         //gameObject.tag = "BlockNotOnCollide";
    //     }
    // }

    // public void SpawnCoins ()
    // {
    //     int coinsToSpawn = 10;
    //     GameObject test = coinPrefab;
    //     Vector3 myScale = test.transform.localScale;
    //     for (int i = 0; i < coinsToSpawn; i++) {
    //         GameObject temp = Instantiate(coinPrefab, transform);
    //         temp.transform.localScale = myScale;
    //         temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
    //     }
    // }

    // Vector3 GetRandomPointInCollider (Collider collider)
    // {
    //     Vector3 point = new Vector3(
    //         Random.Range(collider.bounds.min.x, collider.bounds.max.x),
    //         Random.Range(collider.bounds.min.y, collider.bounds.max.y),
    //         Random.Range(collider.bounds.min.z, collider.bounds.max.z)
    //         );
    //     if (point != collider.ClosestPoint(point)) {
    //         point = GetRandomPointInCollider(collider);
    //     }

    //     point.y = 1;
    //     return point;
    // }

    
}
