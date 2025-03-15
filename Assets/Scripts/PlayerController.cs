using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 40.0f;
    private const float BackwardSpeed = 20.0f;
    private const float TurnSpeed = 30.0f;

    private float _horizontalInput;
    private float _forwardInput;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");
        
        // Moves the car based on forward input.

        if (_forwardInput < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * BackwardSpeed * _forwardInput);   
        
            // Moves the car based on horizontal input.
            transform.Rotate(Vector3.down * Time.deltaTime * TurnSpeed * _horizontalInput);   
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed * _forwardInput);   
        
            // Moves the car based on horizontal input.
            transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed * _horizontalInput);   
        }
    }
}
