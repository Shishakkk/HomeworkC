using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject levelCompleteUI; // Панель конца уровня
    public Text completionText;        // Текст (опционально)
    public Button nextLevelButton;     // Кнопка следующего уровня
    public Button menuButton;          // Кнопка в меню

    [Header("Settings")]
    public string nextSceneName = "Level2"; // Имя следующей сцены
    public bool isLastLevel = false;        // Последний ли уровень?

    private bool levelCompleted = false;

    void Start()
    {
        // Скрываем UI при старте
        if (levelCompleteUI != null)
            levelCompleteUI.SetActive(false);

        // Настраиваем кнопки
        if (nextLevelButton != null)
            nextLevelButton.onClick.AddListener(LoadNextLevel);

        if (menuButton != null)
            menuButton.onClick.AddListener(GoToMainMenu);

        // Если последний уровень, меняем текст кнопки
        if (isLastLevel && nextLevelButton != null)
        {
            Text buttonText = nextLevelButton.GetComponentInChildren<Text>();
            if (buttonText != null)
                buttonText.text = "ИГРАТЬ СНОВА";
        }
    }

    // Вызывается когда игрок завершает уровень (например, при открытии двери)
    public void CompleteLevel()
    {
        if (levelCompleted) return;

        levelCompleted = true;

        // Показываем UI
        if (levelCompleteUI != null)
            levelCompleteUI.SetActive(true);

        // Останавливаем время
        Time.timeScale = 0f;

        // Отключаем управление игроком
        SetPlayerControl(false);

        Debug.Log("Уровень завершён!");
    }

    // Загрузить следующий уровень
    void LoadNextLevel()
    {
        // Восстанавливаем время
        Time.timeScale = 1f;

        if (isLastLevel)
        {
            // Если последний уровень — перезагружаем текущий
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            // Загружаем следующий уровень
            if (!string.IsNullOrEmpty(nextSceneName))
                SceneManager.LoadScene(nextSceneName);
            else
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Вернуться в главное меню
    void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); // Главное меню
    }

    // Включить/выключить управление игроком
    void SetPlayerControl(bool enable)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            PlayerMovement movement = player.GetComponent<PlayerMovement>();
            if (movement != null)
                movement.enabled = enable;
        }
    }
}
