using UnityEngine;
using UnityEngine.UI;

public class KeyCollector : MonoBehaviour
{
    [Header("UI Settings")]
    public Text keysText;

    [Header("Sound Settings")]
    public AudioClip collectSound;
    public float collectVolume = 0.7f;

    [Header("Game Data")]
    public int keysCollected = 0;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        UpdateUI();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Key"))
        {
            keysCollected++;

            // Звук сбора
            if (collectSound != null)
                audioSource.PlayOneShot(collectSound, collectVolume);

            // Уничтожаем ключ
            Destroy(other.gameObject);

            
            UpdateUI();

            Debug.Log("Ключей собрано: " + keysCollected);
        }
    }

    void UpdateUI()
    {
        if (keysText != null)
            keysText.text = "Ключи: " + keysCollected;
    }
}
