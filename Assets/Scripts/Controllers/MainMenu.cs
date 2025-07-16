using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controllers
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            // Đổi "GameScene" thành đúng tên scene chơi game của bạn
            Time.timeScale = 1f;
            SceneManager.LoadScene("GamePlayScene");

        }
    }
}
