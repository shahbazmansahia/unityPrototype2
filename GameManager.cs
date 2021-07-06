using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeLives(int val)
    {
        lives += val;
        if (lives > 0)
        {
            Debug.Log("Lives = " + lives);
        }
        else
        {
            Debug.Log("Game 0ver");
        }

    }
    public void addScore(int val)
    {
        score += val;
        Debug.Log("Score = " + score);
    }


}
