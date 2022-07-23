using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.LevelComplete();
        gameManager.GameHasEnded = true;
    }
}
