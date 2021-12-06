using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    public int maxGuessesAllowed = 10;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1001;
        min = 1;
        NextGuess();
    }

    public void GuessHiger()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)     { SceneManager.LoadScene("Win"); }
        else text.text = guess.ToString();
    }
}
