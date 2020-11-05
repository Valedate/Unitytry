using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class newtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int Score = 0;
    public GameObject ScoreText;


    public void Count()
    {
        Score++;
        ScoreText.GetComponent<Text>().text = "Score: " + Score.ToString();
    }
}
