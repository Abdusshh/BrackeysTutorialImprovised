using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float ResetTime = 1;
    public GameObject CompleteLevelUI;
    public void LevelComplete()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void endGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("restart",ResetTime);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
