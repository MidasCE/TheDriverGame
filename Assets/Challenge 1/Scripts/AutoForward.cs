using UnityEngine;

namespace Challenge_1.Scripts
{
    public class AutoForward : MonoBehaviour
    {
        private const float Speed = 20.0f;
        
        void Update()
        {
            // Moves based on forward input.
            transform.Translate(Vector3.forward * Time.deltaTime * Speed);   
        }
    }
}