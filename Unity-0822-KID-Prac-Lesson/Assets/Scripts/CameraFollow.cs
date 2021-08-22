using UnityEngine;

namespace KID
{
    public class CameraFollow : MonoBehaviour
    {
        [Header("速度"), Range(0, 1000)]
        public float speed = 1.5f;

        private Transform target;

        private void Start()
        {
            target = GameObject.Find("野蠻人").transform;
        }

        private void LateUpdate()
        {
            Move();
        }

        private void Move()
        {
            Vector3 posTarget = target.position;
            Vector3 posCamera = transform.position;

            posTarget.x -= 3;
            posTarget.y = 11;
            posTarget.z -= 2;

            transform.position = Vector3.Lerp(posCamera, posTarget, 0.5f * Time.deltaTime * speed);
        }
    }
}


