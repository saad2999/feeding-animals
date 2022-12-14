using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward : MonoBehaviour
 {
    public float Speed =2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        if (transform.position.z >= 40f)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= -40f)
        {
            Destroy(gameObject);
        }
    }
}
