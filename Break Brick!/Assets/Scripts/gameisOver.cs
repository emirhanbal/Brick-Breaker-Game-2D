using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameisOver : MonoBehaviour
{
    public UnityEngine.UI.Text score;
    void Start()
    {
        score.text = "Your Score : "+GameObject.FindObjectOfType<ScoreCalculater>().GetComponent<ScoreCalculater>().scoreboard();
    }

    // Update is called once per frame

    // public void playAgain()
    // {
    //     SceneManager.LoadScene(0);
    // }
    

}
