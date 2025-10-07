using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Make sure to include the TextMeshPro namespace

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public GameObject GameOverPanel;

    public void Start() 
    {
        GameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            ScoreText.text = "Score: " + GameManager.Instance.score.ToString();
        }

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
