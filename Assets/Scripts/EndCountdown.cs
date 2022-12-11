using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCountdown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        countdownDisplay.text = "Bonus!";
        yield return new WaitForSeconds(1f);
        while(countdownTime >= 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }
		/* Call the code to "begin" your game here.
		 * For example, mine allows the player to start
		 * moving and starts the in game timer.
         */
		// GameController.instance.BeginGame();
        yield return new WaitForSeconds(1f);
        var demoScene = GameObject.FindObjectOfType<DemoSceneManager>();
        Debug.Log(GameManager.inst.score);
        PlayerPrefs.SetInt("Score", GameManager.inst.score);
        //PlayerPrefs.Save();
        demoScene.LoadSceneWithIndex(4);

        countdownDisplay.gameObject.SetActive(false);
    }
}
