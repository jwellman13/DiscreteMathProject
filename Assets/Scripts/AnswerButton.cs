using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public TextMeshProUGUI buttonText;      //Button text: AiE (Assigned in Editor)
    public SetIntegerController SIC;        //SetIntegerController refererence: AiE
    public Sprite[] panelSprites;           //Sprite array of default, correct, and incorrect button images: AiE
    public GameObject newGameButton;        //New game button: AiE

    void Awake()
    {
        buttonText.text = "";               //Clears button text
    }

    // Compares the answer string to the button text string and changes the button sprite accordingly
    public void CheckAnswer()
    {
        int _correctAnswer = SIC.GetCorrectAnswer();
        int _binaryCorrectAnswer = ConvertToBinary.GetConversion(_correctAnswer);
        string _correctAnswerString = _binaryCorrectAnswer.ToString();

        if (string.Equals(buttonText.text, _correctAnswerString))
        {
            Image _image = this.GetComponent<Image>();
            _image.sprite = panelSprites[1];
            //Sets new game button to active on correct answer to allow for a new game
            newGameButton.SetActive(true);
        }
        else
        {
            Image _image = this.GetComponent<Image>();
            _image.sprite = panelSprites[2];
        }
    }
}
