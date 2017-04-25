using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {


    public void RestartGame()
    {
        Time.timeScale = 1f;
        StartCoroutine(ChangeScene("scene1"));
    }

    private IEnumerator ChangeScene(string sceneToLoad)
    {
        float timeToWait = GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(timeToWait);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
