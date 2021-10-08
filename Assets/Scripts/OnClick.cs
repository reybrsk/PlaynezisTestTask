using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public static Action<CellParam> onCellClicked;
    
    public void OnTheClick()
    {
        if (GetComponent<CellParam>().isDecorative)
        {
            return;
        }
        onCellClicked?.Invoke(GetComponent<CellParam>());
    }
    

}
