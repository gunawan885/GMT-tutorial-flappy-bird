using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logic_script : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

[ContextMenu("increase Score")]
    public void addScore(int scoreToAdd){
        playerScore =playerScore+scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}
