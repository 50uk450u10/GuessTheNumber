using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField input;
    int counter = 3;
    int ranNum;
    bool finish = false;

    public void GameSetup()
    {
        ranNum = Random.Range(0, 11);
        header.text = "Try and guess the number!\nYou have " + counter + " attempts remaining.";
        input.text = "";
    }

    public void SubmitGuess()
    {
        if (input.text != "" && !finish) {
            if (int.Parse(input.text) != ranNum)
            {
                counter -= 1;
                if (counter == 0)
                {
                    finish = true;
                    header.text = "You have LOST";
                }
                else
                {
                    header.text = "You have " + counter + " attempts remaining.";
                }
            }
            else
            {
                header.text = "You win!";
                finish = true;
            }
        }
    }

    public void GameReset()
    {
        counter = 3;
        finish = false;
        GameSetup();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
