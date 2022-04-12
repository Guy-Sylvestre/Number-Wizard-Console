using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    //Fonction ne retournant rien
    void StartGame()
    {
        Debug.Log("Welcome to number wirard, yo");
        Debug.Log("Pick an number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("The lowest number you can pick is 1" + min);
        Debug.Log("Tell me if your number is higher or lower: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {            
            min = guess;
            NextGuess();

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow key was presed");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow key was presed");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Arrow key was presed");
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Je suis un genis");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log(guess);
        Debug.Log("Is it higher or lower... " + guess);
    }
}
