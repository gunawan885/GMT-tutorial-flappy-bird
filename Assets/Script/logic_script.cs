using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logic_script : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;

[ContextMenu("increase Score")]
    public void addScore(int scoreToAdd){
        playerScore =playerScore+scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("clicked");
    }

    public void gameOver (){
        GameOverScreen.SetActive(true);
    }
}
