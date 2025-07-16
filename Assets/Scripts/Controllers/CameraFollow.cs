    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;           // Đối tượng cần bám theo (Player)
        public Vector3 offset;            // Độ lệch so với Player (tùy chỉnh)
        public float smoothSpeed = 5f;    // Tốc độ mượt khi camera di chuyển

        void LateUpdate()
        {
            if (target == null) return;

            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothed = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            // Giữ nguyên Z vì camera orthographic luôn ở -10
            transform.position = new Vector3(smoothed.x, smoothed.y, transform.position.z);
        }
    }
}
