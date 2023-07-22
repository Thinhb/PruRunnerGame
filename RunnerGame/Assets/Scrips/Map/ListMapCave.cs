using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMapCave : ListMap
{
    public GameObject[] listMapCave;


    public override GameObject[] listMap()
    {
        return listMapCave;
    }
}
