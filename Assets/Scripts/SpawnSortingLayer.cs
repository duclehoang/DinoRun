

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSortingLayer : MonoBehaviour
{

    Renderer meshRenderer;

    void Start()
    {
        meshRenderer=GetComponent<Renderer>();
          meshRenderer.sortingOrder=4;
        int orderInLayer = meshRenderer.sortingOrder;
        Debug.Log("spawn: "+meshRenderer.sortingOrder);
        
        // Set Sorting Layer và Order in Layer của đối tượng
       
    }
}


