using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
    public Text countdownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score");
        countdownDisplay.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("Score",0);
        RenderSettings.skybox.SetFloat("_Rotation", 282.0f);
        var demoScene = GameObject.FindObjectOfType<DemoSceneManager>();
        if (other.gameObject.CompareTag("Ball")){
            demoScene.LoadSceneWithIndex(1);
        }
    }
}
