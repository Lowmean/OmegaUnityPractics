using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    
    public Text highscoreText;

    
    int highscore = 764235;

    void Start()
    {
        
        highscoreText.text = "������ ���������: " + highscore.ToString();

    }
    void Update()
    {  
        GameBoardScore.instance.Start();
        highscoreText.text = "������ ���������: " + highscore.ToString();
    }

}
