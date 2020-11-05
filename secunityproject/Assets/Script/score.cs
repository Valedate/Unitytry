using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score = 0;
    public GameObject ScoreText;

    public void Count() {
        Score++;
        ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
    }
    
    
}
