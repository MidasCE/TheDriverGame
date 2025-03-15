using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    private readonly Vector3 _offset = new(0, 6, -12);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + _offset;
    }
}
