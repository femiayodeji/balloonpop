using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject victoryText;

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
    }
}
