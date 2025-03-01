using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public GameObject[] rooms;
    public Transform player;
    private float nextSpawnY;
    public float roomHeight = 7f; 
    private readonly int initialRooms = 5;

    void Start()
    {
        nextSpawnY = 0;
        for (int i = 0; i < initialRooms; i++)
        {
            SpawnRoom();
        }
    }

    public void SpawnRoom()
    {
        Instantiate(rooms[Random.Range(0, rooms.Length)], new Vector2(0, nextSpawnY - roomHeight), Quaternion.identity);
        nextSpawnY -= roomHeight;
    }
}
