using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinControllerX : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Propellor;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Propellor.transform.Rotate(new Vector3 (0, 0, 20) * Time.deltaTime * 15);
    }
}
