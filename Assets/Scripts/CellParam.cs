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


    private int _oldHouseVar = 0;               // версия дома для сравнения
    private int _oldHouseLevel = 0;// левел дома для сравнения
    private GameObject _targetHouse;// дом который НАДО поставить в клетку. Берется из каталога
    private GameObject _oldHouse;// дом который СЕЙЧАС стоит в клетке
    private Houses houses;// КАТАЛОГ
    private void Start()
    {
        houses = FindObjectOfType<Houses>();// инициализирую каталог
        if (isDecorative)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            Instantiate(decor, gameObject.transform.position, Quaternion.identity,gameObject.transform);
            return;
        }
    }

    private void Update()
    {
        if(isDecorative) return;
        
        if (_oldHouseLevel != houseLevel || _oldHouseVar != houseVar) /// если версия или лэвел поменялись
                                                                      
        {
            if (_oldHouse != null)
                Destroy(_oldHouse.gameObject);                                         //убить старый дом
            
           
            _targetHouse = houses.GetGameObject(houseVar, houseLevel);// достать новый
            var kek = Instantiate(_targetHouse, transform.position,
                                Quaternion.identity,gameObject.transform);// инстанснуть его на место
            _oldHouseLevel = houseLevel;//переписать левел
            _oldHouseVar = houseVar;//переписать версию
            _oldHouse = kek;// переписать олдхаус
        }
    }
}
