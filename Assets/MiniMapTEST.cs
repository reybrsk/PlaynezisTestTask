using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapTEST : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Text _text;
    public GameObject grid;
    private List<GameObject> _cells;
    private Vector2 _gridSize;
    private Vector2 _position;
    [SerializeField, Range(0f, 100f)] private float distance;



    private float xSizeX;
    private float ySizeY;



    // Start is called before the first frame update
    public void Generate()
    {
        _cells = grid.GetComponent<grid>().cells;
        _gridSize = grid.GetComponent<grid>().gridSize;
        xSizeX = _gridSize.x;
        ySizeY = _gridSize.y;


        for (int x = 0; x < xSizeX; x++)
        {
            for (int y = 0; y < ySizeY; y++)
            {
                _position = new Vector2(transform.position.x + (x + distance * x),
                    transform.position.y + (y + distance * y));
                Vector3 var = (Vector3)(_position);
                Image img = Instantiate(_image, var, Quaternion.identity, transform);
                Text txt = Instantiate(_text, var, Quaternion.identity, img.transform);

                if (_cells[(int)(x * ySizeY + y)].GetComponent<CellParam>().isDecorative)
                {
                    txt.text = $"dec";
                    
                }
                else
                {
                    txt.text = String.Concat(
                        _cells[(int)(x * ySizeY + y)].GetComponent<CellParam>().houseVar.ToString(),
                        _cells[(int)(x * ySizeY + y)].GetComponent<CellParam>().houseLevel.ToString());

                   
                }
            }

        }

    }
}

