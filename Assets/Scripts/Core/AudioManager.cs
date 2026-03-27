using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    void Awake()
    {
        Checkpoint.PlayCheckpointSound += PlaySound;
    }

    private void PlaySound()
    {
       sound.Play();
    }
}
