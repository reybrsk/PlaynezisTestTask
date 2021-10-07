using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
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
        Debug.Log("OpenCanvas()");
        Debug.Log(transform.position);
    }
}
