using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;


public class grid : MonoBehaviour
{
    public Vector2Int gridSize = Vector2Int.one*5;
    public GameObject cell;
    public List<GameObject> GameObjects;
    [SerializeField,Range(0f,1f)] private float distance;

    

    // Start is called before the first frame update
    void Awake()
    {
        for (int x = 0; x < gridSize.x; x++)
        {
            for (int y = 0; y < gridSize.y; y++)
            {
                var gameObject = Instantiate(cell, new Vector3(x+distance*x, 0, y+distance*y), Quaternion.identity);
                
                
                if ((x + y) % 2 != 0)
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    GameObjects.Add(gameObject);
                }
                else
                {
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    GameObjects.Add(gameObject);
                }
            }
        }
        
        
        
        for (int i = 0; i < 5; i++)
        {
            var rand = Random.Range(0, GameObjects.Count);
            if (GameObjects[rand].GetComponent<CellParam>().isDecorative == false)
            {
                GameObjects[rand].GetComponent<CellParam>().isDecorative = true;
            }
            else
            {
                i--;
            }
        }
        
        for (int i = 0; i < GameObjects.Count; i++)
        {
            GameObjects[i].GetComponent<CellParam>().number = i;
        }
    }

  

    
}
