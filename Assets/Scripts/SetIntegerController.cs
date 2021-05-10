using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class SetIntegerController : MonoBehaviour
{
    public TextMeshProUGUI firstIntegerText;                //Button text for first random integer: AiE (Assigned in Editor)            
    public TextMeshProUGUI secondIntegerText;               //Button text for second random integer: AiE

    public TextMeshProUGUI answerButton1;                   //Button text for answer buttons: AiE
    public TextMeshProUGUI answerButton2;                   //Button text for answer buttons: AiE
    public TextMeshProUGUI answerButton3;                   //Button text for answer buttons: AiE
    public TextMeshProUGUI answerButton4;                   //Button text for answer buttons: AiE

    private int _firstInt;                                  //Integer reference for first random integer
    private int _secondInt;                                 //Integer reference for second random integer

    //List of answer buttons. Could probably be moved inside a method
    List<TextMeshProUGUI> _answerButtons = new List<TextMeshProUGUI>();

    private int _correctAnswer;                             //Integer value of the sum of integers

    private void Start()
    {
        CreateButtonList();
        SetIntTerms();
        SetCorrectAnswer();
        PopulateAnswerButtons();
    }
    private void CreateButtonList()
    {
        _answerButtons.Add(answerButton1);
        _answerButtons.Add(answerButton2);
        _answerButtons.Add(answerButton3);
        _answerButtons.Add(answerButton4);
    }

    //Creates random values for the integer terms and sets the button displays
    private void SetIntTerms()
    {
        _firstInt = UnityEngine.Random.Range(1, 16);
        _secondInt = UnityEngine.Random.Range(1, 16);

        firstIntegerText.text = _firstInt.ToString();
        secondIntegerText.text = _secondInt.ToString();
    }

    //Sets _correctAnswer as the sum of integers
    public void SetCorrectAnswer()
    {
        _correctAnswer = _firstInt + _secondInt;
    }
    
    //Creates random int values for the answer buttons and coverts the int into a string for the button display
    private void PopulateAnswerButtons()
    {
        foreach (TextMeshProUGUI answerButton in _answerButtons)
        {
            int _rnd = UnityEngine.Random.Range(2, 32);
            int _binaryRnd = ConvertToBinary.GetConversion(_rnd);
            answerButton.text = _binaryRnd.ToString();
        }

        //After setting the answers with random values, sets correct value for one button
        SetCorrectAnswerButton();
    }

    //Sets a random button with the _correctAnswer
    private void SetCorrectAnswerButton()
    {
        int _rnd = UnityEngine.Random.Range(1, 4);
        TextMeshProUGUI _text = _answerButtons[_rnd];
        int _correctBinaryAnswer = ConvertToBinary.GetConversion(_correctAnswer);
        _text.text = _correctBinaryAnswer.ToString();
    }

    //Accessor for _correctAnswer
    public int GetCorrectAnswer()
    {
        return _correctAnswer;
    }

}
