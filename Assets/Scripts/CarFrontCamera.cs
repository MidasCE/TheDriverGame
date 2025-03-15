using UnityEngine;

namespace DefaultNamespace
{
    public class CarFrontCamera : MonoBehaviour
    {
        public GameObject car;
    
        private readonly Vector3 _offset = new(0, 6, -12);
        void Start()
        {
        
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = car.transform.position + _offset;
        }
    }
}