using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30f;
    private float bottomBound = -10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z < -10 || gameObject.transform.position.z > 30f){
            Destroy(gameObject);
        }
    }
}
