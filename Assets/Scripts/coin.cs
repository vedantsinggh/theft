using UnityEngine;

public class coin : MonoBehaviour
{
    private AudioManager audioManager;

    void Start()
    {
        audioManager = GameObject.FindWithTag("AudioManager").GetComponent<AudioManager>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        audioManager.CoinSound();   
    }
}
