using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        int distance = (int)player.position.z;

        if (distance % 5 == 0)
        {
            scoreText.text = distance.ToString();
        }
    }
}
