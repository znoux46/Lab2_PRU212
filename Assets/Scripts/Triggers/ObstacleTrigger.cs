using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Triggers
{
    public class ObstacleTrigger : MonoBehaviour
    {
        public BoolVariable IsAlive;

        [Tooltip("Event invoked when colliding with obstacle.")]
        public UnityEvent ObstacleCollisionEvent;

        [Tooltip("Obstacle objects that cause death.")]
        public GameObject[] ObstacleCandidates;

        private HashSet<GameObject> obstacleSet;

        private void Awake()
        {
            this.obstacleSet = new HashSet<GameObject>(this.ObstacleCandidates);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (this.obstacleSet.Contains(other.gameObject) && this.IsAlive.Value)
            {
                this.ObstacleCollisionEvent.Invoke();
            }
        }
    }
}
