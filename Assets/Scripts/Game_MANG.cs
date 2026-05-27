using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_MANG : MonoBehaviour
{
    bool GameHasEnded = false;
    public float RestartDelay = 1f;
    public GameObject CompleteLevelUi;

    public void CompleteLevel()
    {
        CompleteLevelUi.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("End game");
            Invoke("Restart", RestartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
