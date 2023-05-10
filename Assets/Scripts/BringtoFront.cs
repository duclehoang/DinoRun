using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringtoFront : MonoBehaviour
{

    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer=GetComponent<MeshRenderer>();
         meshRenderer.sortingOrder=-1;
         int orderInLayer = meshRenderer.sortingOrder;
        Debug.Log(meshRenderer.sortingOrder);
        
        // Set Sorting Layer và Order in Layer của đối tượng
       
    }
}

