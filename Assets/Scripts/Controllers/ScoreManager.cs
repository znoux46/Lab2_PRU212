using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class ScoreManager : MonoBehaviour
    {
        public static ScoreManager Instance;
        public TMP_Text scoreText; // đổi thành Text nếu dùng UI Text cũ
        private int score;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        public void AddScore(int amount)
        {
            score += amount;
            Debug.Log("Score: " + score);
            scoreText.text = "Score: " + score;
        }
    }
}
