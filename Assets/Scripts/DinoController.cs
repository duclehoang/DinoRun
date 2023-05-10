using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DinoController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float jumForce;
    bool gameOver = false;
    bool grounded = false;
    Animator animator ;
    AudioSundEffect effect;
   

    private void Awake() {
        rb=GetComponent<Rigidbody2D>();
        animator=GetComponent<Animator>();
        effect=FindObjectOfType<AudioSundEffect>();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if(SceneManager.GetActiveScene().name=="game"){
           
            if((Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)||(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))&&!gameOver){
           if(grounded){
                  jump();
                 
                  
                 
           }
          
        }
        }
      
        
    }

    void jump(){
         grounded=false;
        rb.AddForce(Vector2.up * jumForce,ForceMode2D.Impulse);
        animator.SetTrigger("Jump");
         effect.musicJump1();
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("ground")){
            grounded=true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("obstacle")){
            Destroy(other.gameObject);
                animator.Play("Dead");
               GetComponent<CapsuleCollider2D>().direction=CapsuleDirection2D.Vertical;
                GameManager.instance.GameOver();
                gameOver=true;

        }
    }
}
