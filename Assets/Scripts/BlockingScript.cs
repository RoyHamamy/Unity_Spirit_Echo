using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingScript : MonoBehaviour
{   
    void Start()
    {
    }

    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other) {
        if(other.CompareTag("Player")){
            PlayerMechanics.Instance.timeTraverseEnabled = false;
        }

    }

    void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player")){
            PlayerMechanics.Instance.timeTraverseEnabled = true;
        }
    }
}
