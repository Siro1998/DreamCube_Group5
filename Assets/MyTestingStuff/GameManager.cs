using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score;
    public float Skyboxspeed;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] public HealthController _healthController;

    // Start is called before the first frame update
    // public void IncrementScore ()
    // {
    //     score++;
    //     scoreText.text = "SCORE: " + score;
    //     // Increase the player's speed
    //     playerMovement.speed += playerMovement.speedIncreasePerPoint;
    // }
    void Start()
    {
        _healthController.UpdateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time*Skyboxspeed);
    }
}
