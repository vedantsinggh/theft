using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource CoinSoundAudio;
    public void CoinSound(){
        CoinSoundAudio.Play();
    }
}
