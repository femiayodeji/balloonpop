using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject victoryText;
    public GameObject restartButton;

    private int score = 0;

    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;
        if (score >= 4)
        {
            Victory();
        }
    } 
 
    private void Victory()
    {
        victoryText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
