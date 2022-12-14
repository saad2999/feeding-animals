using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestoryONcollion : MonoBehaviour
{
    // Start is called before the first frame update
    private string ForestAni = "ForestAnimal";
    
    
    void Start()
    {
        
    
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    private void OnTriggerEnter(Collider other)
   {
        if (gameObject.tag==ForestAni)
        {
            Debug.LogError("GAME OVER");
            

            
        }
        else 
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
