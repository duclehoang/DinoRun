using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obStacles;
    public float minSpawneTime,maxSpaweTime;
    void Start()
    {
        StartCoroutine("Spawn");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Spawn(){
        float waittime=1f;
        while(true){
            Spawnobstacle();
            waittime=Random.Range(minSpawneTime,maxSpaweTime);

            yield return new WaitForSeconds(waittime);
        }
    }

    void Spawnobstacle(){
        int random = Random.Range(0,obStacles.Length);
        Instantiate(obStacles[random],transform.position,Quaternion.identity);

    }
}
