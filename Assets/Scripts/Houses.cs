using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Houses : MonoBehaviour
{

    [SerializeField]private GameObject[] houseVar1;
    [SerializeField]private GameObject[] houseVer2;

    public GameObject GetGameObject(int variant, int level)
    {
        if (variant == 0 || variant > 2)
        {
            return null;
        }

        if (variant == 1)
        {
            return houseVar1[level-1];
        }

        if (variant == 2)
        {
            return houseVer2[level-1];
        }

        return null;
    }
}
