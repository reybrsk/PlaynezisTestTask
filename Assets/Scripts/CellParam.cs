using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellParam : MonoBehaviour
{
    
    [SerializeField] private GameObject decor;
    public int number = 0;
    public bool isDecorative = false;
    public int houseVar = 0;
    public int houseLevel = 0;
    
    private void Start()
    { 
        if (isDecorative)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            Instantiate(decor, gameObject.transform.position, Quaternion.identity);
            return;
        }
    }
}
