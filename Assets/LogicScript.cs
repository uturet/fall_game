using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text textScore;

    void Start()
    {
         textScore.text = score.ToString();
    }

    [ContextMenu("Increment Score")]
    public void IncrementScore()
    {
        score++;
        textScore.text = score.ToString();
    }
}

