using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuessingGame : MonoBehaviour
{
    int minValue;
    int maxValue;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            NextGuess();
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            NextGuess();
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed your number, I'm a genius!");
            StartGame();
        }
    }

    void StartGame()
    {
        minValue = 1;
        maxValue = 100;
        guess = 50;

        Debug.Log("Welcome to the Number Guessing Game.");
        Debug.Log("Guess a number between " + minValue + " and " + maxValue + ", but don't tell me");
        Debug.Log("Is your number " + guess + "?");
        Debug.Log("Press the Up Arrow, if your number is higher.");
        Debug.Log("Press the Down Arrow, if your number is lower.");
        Debug.Log("Press the Enter key, if I guessed your number.");
        maxValue = maxValue + 1;
    }

    void NextGuess()
    {
        guess = (maxValue + minValue) / 2;
        Debug.Log("Is the number higher or lower than " + guess);
    }
}
