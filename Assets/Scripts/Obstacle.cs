using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
   public float moveSpeed;
    Rigidbody2D rb;
    public int scorePoint;
    bool scoreUpdate =false;

    private void Awake() {
          rb=GetComponent<Rigidbody2D>();
    }
    void Start()
    {
      rb.velocity=Vector2.left*moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if((transform.position.x < scorePoint)&&!scoreUpdate){
            
            scoreUpdate=true;


        }
        if(transform.position.x<-15){
            Destroy(gameObject);
            GameManager.instance.IncrementScore();
        }
    }
}
