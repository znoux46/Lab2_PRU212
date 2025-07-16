using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Controllers
{
    public class PlayAgain : MonoBehaviour
    {
        public void PlayGameAgain()
        {
            // Load lại Scene hiện tại
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
