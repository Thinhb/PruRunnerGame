using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AbstractMapFactory:MonoBehaviour
{
    public string mapName;
    public abstract void RandomMap();
}
