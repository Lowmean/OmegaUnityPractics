using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameBoardScore : MonoBehaviour
{
    public static GameBoardScore instance;
    
    public float timeStart = 10f;
    public Text scoreText;
    public Text timeText;
    public GameObject GameOver;
    public GameObject GameBoard;

 
    public int score = 0;
    
    private void Awake()
    {
        instance = this;
    }
    public void Start()
    {
        scoreText.text = "Результат: " + score.ToString();
        timeText.text =  timeStart.ToString();

    }
    public void Update()
    {
        if (timeStart > 0) { 
            
            timeStart -= Time.deltaTime;
            timeText.text = Mathf.Round(timeStart).ToString();
            } 
        else 
        {
            PlayerPrefs.SetInt("",score);
            PlayerPrefs.Save();
            GameOver.SetActive(true);
            GameBoard.SetActive(false);
        }
         
       

    }
   

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Результат: " + score.ToString();
        PlayerPrefs.Save();
    }
    
    public void AddTime()
    {
        timeStart += 0.5f;
        timeText.text =  timeStart.ToString();
    }

}
