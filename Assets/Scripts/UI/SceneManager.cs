using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    private GameObject pauseCanvas;
    public GameObject deathCanvas;

    private void Start()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        pauseCanvas = GameObject.FindGameObjectWithTag("PauseCanvas");
        deathCanvas = GameObject.FindGameObjectWithTag("DeathCanvas");
        deathCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                Cursor.visible = true;
                pauseCanvas.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                Cursor.visible = false;
                pauseCanvas.SetActive(false);
            }
        }
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        StartCoroutine(ChangeScene("scene1"));
    }

    private IEnumerator ChangeScene(string sceneToLoad)
    {
        float timeToWait = GetComponent<Fading>().BeginFade(1);
        deathCanvas.SetActive(false);
        yield return new WaitForSeconds(timeToWait);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
