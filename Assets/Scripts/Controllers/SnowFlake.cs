using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class Snowflake : MonoBehaviour
    {
        public int pointValue = 1;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Player đã chạm vào hoa tuyết");
                ScoreManager.Instance.AddScore(pointValue);
                Destroy(gameObject); // Snowflake biến mất
            }
        }
    }
}
