using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restart : MonoBehaviour
{
    public Text countdownDisplay;
    public Text highestScore;
    int highestscore;

    // Start is called before the first frame update
    void Start()
    {
        highestscore = PlayerPrefs.GetInt("HighestScore");
        int score = PlayerPrefs.GetInt("Score");
        if(score>highestscore){
            highestscore = score;
        }
        highestScore.text= highestscore.ToString();
        countdownDisplay.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.SetInt("HighestScore", highestscore);
        PlayerPrefs.Save();
        RenderSettings.skybox.SetFloat("_Rotation", 282.0f);
        var demoScene = GameObject.FindObjectOfType<DemoSceneManager>();
        if (other.gameObject.CompareTag("Ball")){
            demoScene.LoadSceneWithIndex(1);
        }
    }
}
