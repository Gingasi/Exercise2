using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EXERCISE5 : MonoBehaviour
{
    public string[] CHZodiac;
    public GameObject YearInput;
    public TMP_InputField YearInputField;
    public int Year;
    public int CHHoroscopeInt;
    public GameObject[] ZodiacImages;

    public void GoButton()
    {
        if (YearInputField.text != "")
        {
            Year = int.Parse(YearInputField.text); 
            CHHoroscopeInt = Year % 12;
            YearInput.SetActive(false);
            
        }
    }
}
