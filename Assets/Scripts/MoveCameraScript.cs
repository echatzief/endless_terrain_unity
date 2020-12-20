using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraScript : MonoBehaviour{
    
    public float speed=2f;
    public SpawnManager spawnManager;
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        float Horizontal = Input.GetAxis("Vertical");

       
        Vector3 moveDirection = new Vector3(Horizontal,0.0f,0.0f);
        transform.position += moveDirection*speed;
    }

    private void OnTriggerEnter(){
        print("Spawn Trigger");
        spawnManager.SpawnTriggerEntered();
    }
}
