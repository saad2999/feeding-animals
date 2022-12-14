using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float horizontal=0 ;
    public float speed = 17f;
    float horizonalBound = 20f;
   public GameObject[] projectile;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate( Vector3.right* horizontal * Time.deltaTime * speed);
        if (transform.position.x >= horizonalBound)
        {
            transform.position = new Vector3(horizonalBound, transform.position.y, transform.position.z);
        }
        
        else if (transform.position.x <= -horizonalBound)
        {
            transform.position = new Vector3(-horizonalBound, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int foodIndex = Random.Range(0, projectile.Length);
            Instantiate(projectile[foodIndex], transform.position, projectile[foodIndex].transform.rotation);
        }
        
        
    }
}
