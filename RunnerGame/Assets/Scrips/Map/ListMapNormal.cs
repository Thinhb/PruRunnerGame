using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMapNormal : ListMap
{
    public GameObject[] listMapNormal;
    public override GameObject[] listMap()
    {
        return listMapNormal;
    }
}
