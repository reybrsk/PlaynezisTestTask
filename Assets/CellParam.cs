using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellParam : MonoBehaviour
{
    public bool isDecorative = false;
    [SerializeField] private GameObject decor;
    public int number = 0;


    private void Start()
    {
        if (isDecorative)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            Instantiate(decor, gameObject.transform.position, Quaternion.identity);
        }
    }
}
