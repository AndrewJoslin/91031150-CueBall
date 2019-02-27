using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 180f;

    [SerializeField] Text CountdownText;


    // Use this for initialization
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString();


        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
            GameOver();
    }

    private void GameOver()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }

}