using UnityEngine;
using UnityEngine.Events;
using System;

public class Checkpoint : MonoBehaviour
{
    public SaveManager saveManager; 

    private SpriteRenderer sRend;

    public static event Action PlayCheckpointSound;

    private void Awake()
    {
        sRend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sRend.color = Color.green;

            saveManager.SaveGame(collision.transform.position);

            PlayCheckpointSound.Invoke();

            Debug.Log("Checkpoint Reached!");
        }
    }

}
