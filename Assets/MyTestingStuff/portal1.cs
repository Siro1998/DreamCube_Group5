using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal1 : MonoBehaviour
{
    //private DemoSceneManager demoScene;

    // Start is called before the first frame update
    void Start()
    {
        //demoScene = GameObject.Find("SceneManager").GetComponent<DemoSceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var demoScene = GameObject.FindObjectOfType<DemoSceneManager>();
        if (other.gameObject.CompareTag("Ball"))
            demoScene.LoadSceneWithIndex(0);
    }

}