using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class CashParser : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText()
    {
        _text.text = GetParsedText();
    }

    private string GetParsedText()
    {
        string value = _text.text;
        string result = "";

        for (int i = 0; i < value.Length; i++)
        {
            result += value[i].ToString();
            if ((value.Length - (i + 1)) % 3 == 0) result += " ";
        }
        
        return result + "$";
    }
}
