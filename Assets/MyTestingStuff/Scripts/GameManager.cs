using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public float Skyboxspeed;
    public static GameManager inst;
    [SerializeField] TextMeshProUGUI scoreText;
    //[SerializeField] public HealthController _healthController;

     public void IncrementScore (int num)
     {
         score+=num;
         scoreText.text = "SCORE: " + score;
     }

    public void DecrementScore ()
     {
         score-=50;
         scoreText.text = "SCORE: " + score;
     }

    private void Awake ()
    {
        inst = this;
    }

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = "SCORE: " + score;
        //_healthController.UpdateHealth();
    }

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", 282.0f+Time.time*Skyboxspeed);
    }
}
