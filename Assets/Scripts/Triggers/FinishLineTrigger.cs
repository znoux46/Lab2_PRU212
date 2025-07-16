using Assets.Scripts.Controllers;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FinishLineTrigger : MonoBehaviour
{
    public GameObject winPanel;
    public TextMeshProUGUI scoreText;
    public AudioSource winAudio;
    public ScoreManager scoreManager; // Nếu bạn có class quản lý điểm

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("WIN! Chạm cột đích");
            winPanel.SetActive(true);
            winAudio.Play();
            Time.timeScale = 0f; // Dừng game
            //scoreText.text = "Total Score: " + scoreManager.scoreText;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
