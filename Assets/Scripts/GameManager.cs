using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 계산기 디스플레이
    public TMP_Text displayText;

    // 버튼 클릭 이벤트
    public void OnClickButton(string buttonStr)
    {
        switch (buttonStr)
        {
            case "0":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "1":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "2":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "3":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "4":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "5":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "6":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "7":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "8":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "9":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case ".":
                if (displayText.text == "0")
                {
                    displayText.text = buttonStr;
                }
                else
                {
                    displayText.text += buttonStr;
                }
                break;
            case "c":
                break;
            case "+":
                break;
            case "-":
                break;
            case "*":
                break;
            case "/":
                break;
            case "=":
                break;

        }
    }
}
