using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletion : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+ 1 );
        // Build indexlere 1 ekleyerek sonraki sahneleri yüklüyoruz.
    }
}
