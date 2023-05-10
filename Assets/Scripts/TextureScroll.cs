using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float ScrollSpeed;
    public bool scroll=true;
    Material backgroundMaterial;

     private void Awake() {
       backgroundMaterial=GetComponent<Renderer>().material; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {
        if (scroll){
            Vector2 offset=new Vector2(ScrollSpeed *Time.time,0);
            backgroundMaterial.mainTextureOffset=offset;
        }
    }
}
