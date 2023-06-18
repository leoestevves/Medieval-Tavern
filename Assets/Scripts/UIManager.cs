using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    CountdownTimer countdownTimer;
    LogicScript logicScript;

    [Header("GameActive")]
    [SerializeField] GameObject gameActiveScreenUI;
    [SerializeField] Text gameActiveScore;
    public bool gameIsActive = true;

    [Header("Pause")]
    [SerializeField] GameObject pauseMenuScreenUI;

    [Header("EndGame")]
    [SerializeField] GameObject gameOverScreenUI;
    [SerializeField] Text gameOverScore;

    void Start()
    {
        countdownTimer = GameObject.FindGameObjectWithTag("Logic").GetComponent<CountdownTimer>();
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownTimer.currentTime == 0)
        {
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsActive)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }

    }

    void GameOver()
    {
        gameOverScreenUI.SetActive(true); //Ativa a tela de fim de jogo
        gameActiveScreenUI.SetActive(false); //Desativa a UI da parte de montagem de sanduiches

        gameOverScore.text = logicScript.playerScore.ToString(); //Passa o score da UI de montagem para a UI do gameOver

        gameIsActive = false;
    }

    public void RestartGame()
    {
        gameIsActive = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        pauseMenuScreenUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsActive = true;
    }

    public void Pause()
    {
        pauseMenuScreenUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsActive = false;
    }
}
