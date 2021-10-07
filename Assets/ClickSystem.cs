using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSystem : MonoBehaviour
{
    private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray, 100f);
            for (int i = 0; i < hits.Length; i++)
            {
                if (hits[i].collider.gameObject.CompareTag("Cell"))
                {
                    hits[i].collider.gameObject.GetComponent<OnClick>().OnTheClick();
                }
            }
        }
    }
}
