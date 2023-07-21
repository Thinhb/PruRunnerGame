using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientFactoryMap : MonoBehaviour
{
    public void ClientMethor(AbstractMapFactory abstractMap)
    {
        abstractMap.RandomMap();
    }
}
