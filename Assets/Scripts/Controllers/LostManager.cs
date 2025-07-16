using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class LostManager : MonoBehaviour
    {
        public GameObject LostPanel;

        public void ShowGameOverPanel()
        {
            LostPanel.SetActive(true);
        }
    }
}
