using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{

    private Text text;
    private int number;

    private void Start()
    {
        number = GetComponent<CellParam>().number;
        GetComponentInChildren<Text>().text = number.ToString();
    }

    public void OnTheClick()
    {
        if (GetComponent<CellParam>().isDecorative)
        {
            return;
        }

        OpenCanvas();

    }

    private void OpenCanvas()
    {
        GetComponentInChildren<Canvas>().enabled = true;
    }
}
