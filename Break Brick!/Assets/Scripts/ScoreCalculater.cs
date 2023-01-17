using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculater : MonoBehaviour
{
    private int _score;

    public void scoreIncrease()
    {
        _score++;
    }
    public int scoreboard()
    {
        return _score;
    }

    public void resetScore()
    {
        _score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
