using UnityEngine;
using UnityEngine.UI;

public class DoorController : MonoBehaviour
{
    [Header("Door Settings")]
    public int keysRequired = 3;

    [Header("Sound Settings")]
    public AudioClip doorOpenSound;
    public float doorVolume = 0.7f;

    [Header("UI Settings")]
    public Text messageText;

    private bool isDoorOpen = false;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        // Скрываем сообщение при старте
        if (messageText != null)
            messageText.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isDoorOpen)
        {
            KeyCollector playerKeys = other.GetComponent<KeyCollector>();

            if (playerKeys != null)
            {
                if (playerKeys.keysCollected >= keysRequired)
                {
                    OpenDoor();
                }
                else
                {
                    ShowMessage($"Нужно ключей: {keysRequired}");
                }
            }
        }
    }

    void OpenDoor()
    {
        isDoorOpen = true;

        // Звук открытия двери
        if (doorOpenSound != null && audioSource != null)
            audioSource.PlayOneShot(doorOpenSound, doorVolume);

        // Меняем цвет на зелёный
        spriteRenderer.color = Color.green;

        // Отключаем коллайдер
        GetComponent<Collider2D>().enabled = false;

        // Сообщение
        ShowMessage("Уровень пройден!");

        // Завершаем уровень (через 1 секунду, чтобы увидеть сообщение)
        Invoke("CompleteLevelAction", 1f);
    }

    void CompleteLevelAction()
    {
        // Ищем объект LevelComplete на сцене
        LevelComplete levelComplete = FindObjectOfType<LevelComplete>();
        if (levelComplete != null)
        {
            levelComplete.CompleteLevel();
        }
        else
        {
            Debug.LogWarning("LevelComplete не найден! Создайте объект с этим скриптом.");
        }
    }

    void ShowMessage(string text)
    {
        if (messageText != null)
        {
            messageText.text = text;
            messageText.gameObject.SetActive(true);

            // Скрываем сообщение через 2 секунды
            Invoke("HideMessage", 2f);
        }
    }

    void HideMessage()
    {
        if (messageText != null)
            messageText.gameObject.SetActive(false);
    }
}
