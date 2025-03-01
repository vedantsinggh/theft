using System;
using UnityEngine;

public class Roof : MonoBehaviour
{
    private int count = 0;
    [SerializeField] private RoomSpawner roomSpawner;
    void Start()
    {
        roomSpawner = GameObject.FindWithTag("Spawner").GetComponent<RoomSpawner>();
        count = 0;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player")) count++;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(count >= 2){
            //Destroy(gameObject);
            Destroy(gameObject.GetComponent<BoxCollider2D>());
            roomSpawner.SpawnRoom();
        }
    }
}
