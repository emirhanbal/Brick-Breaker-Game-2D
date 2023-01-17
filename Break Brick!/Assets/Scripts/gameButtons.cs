using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        isBrickBroken.totalBrick = 0;
        GameObject.FindObjectOfType<ScoreCalculater>().GetComponent<ScoreCalculater>().resetScore();
        SceneManager.LoadScene("Level1Scene");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
