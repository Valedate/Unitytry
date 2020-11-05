using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
    public int Score = 0;
    public GameObject ScoreText;

    public void OnTriggerEnter(Collider other)
    {
        Score++;
        ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
    }

    
}
