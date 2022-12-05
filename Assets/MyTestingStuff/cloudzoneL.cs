using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudzoneL : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        var demoScene = GameObject.FindObjectOfType<DemoSceneManager>();
        if (other.gameObject.CompareTag("Ball")){
            demoScene.LoadSceneWithIndex(1);
        }
    }
}
