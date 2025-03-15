using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed;
    
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
