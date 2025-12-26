using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    [Header("UI References")]
    public GameObject pauseMenu;       // Панель меню паузы
    public Button resumeButton;        // Кнопка "Продолжить"
    public Button menuButton;          // Кнопка "В меню"

    [Header("Settings")]
    public KeyCode pauseKey = KeyCode.Escape; // Клавиша паузы

    private bool isPaused = false;

    void Start()
    {
        // Настраиваем кнопки
        if (resumeButton != null)
            resumeButton.onClick.AddListener(ResumeGame);

        if (menuButton != null)
            menuButton.onClick.AddListener(GoToMainMenu);

        // Скрываем меню при старте
        if (pauseMenu != null)
            pauseMenu.SetActive(false);
    }

    void Update()
    {
        // Проверяем нажатие клавиши паузы
        if (Input.GetKeyDown(pauseKey))
        {
            TogglePause();
        }
    }

    // Включить/выключить паузу
    public void TogglePause()
    {
        isPaused = !isPaused;

        // Показываем/скрываем меню
        if (pauseMenu != null)
            pauseMenu.SetActive(isPaused);

        // Останавливаем/возобновляем время
        Time.timeScale = isPaused ? 0f : 1f;

        // Блокируем/разблокируем управление игроком
        SetPlayerControl(!isPaused);

        Debug.Log(isPaused ? "Игра на паузе" : "Игра продолжается");
    }

    // Продолжить игру
    public void ResumeGame()
    {
        if (isPaused)
            TogglePause();
    }

    // Выйти в главное меню
    public void GoToMainMenu()
    {
        // Возвращаем нормальную скорость времени
        Time.timeScale = 1f;

        // Загружаем главное меню (сцена с индексом 0)
        SceneManager.LoadScene(0);
    }

    // Включить/выключить управление игроком
    private void SetPlayerControl(bool enable)
    {
        // Находим игрока на сцене
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // Включаем/выключаем скрипт движения
            PlayerMovement movement = player.GetComponent<PlayerMovement>();
            if (movement != null)
                movement.enabled = enable;
        }
    }

    // Метод для проверки состояния паузы (может пригодиться другим скриптам)
    public bool IsGamePaused()
    {
        return isPaused;
    }
}   
