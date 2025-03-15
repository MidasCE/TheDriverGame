using UnityEngine;

using System.Collections.Generic;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab;
    public int roadCount = 5;  // Number of road segments to maintain
    public float roadLength = 20f;  // Length of each road segment
    public Transform player;  // Reference to the player's transform

    private readonly Queue<GameObject> _roadSegments = new();

    void Start()
    {
        // Spawn initial road segments
        for (int i = 0; i < roadCount; i++)
        {
            Vector3 spawnPos = new Vector3(0, 0, i * roadLength);
            GameObject road = Instantiate(roadPrefab, spawnPos, Quaternion.identity);
            _roadSegments.Enqueue(road);
        }
    }

    void Update()
    {
        // Move road when the player reaches a certain point
        if (player.position.z > _roadSegments.Peek().transform.position.z + roadLength)
        {
            GameObject oldRoad = _roadSegments.Dequeue();
            oldRoad.transform.position += Vector3.forward * (roadCount * roadLength);
            _roadSegments.Enqueue(oldRoad);
        }
    }
}