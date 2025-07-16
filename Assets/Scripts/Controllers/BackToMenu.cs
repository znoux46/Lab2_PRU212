using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controllers
{
    public class BackToMenu : MonoBehaviour
    {
        public void BackToMainMenu()
        {
            // Đổi "GameScene" thành đúng tên scene chơi game của bạn
            SceneManager.LoadScene("MainMenu");
        }
    }
}
