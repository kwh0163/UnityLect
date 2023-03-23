using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vector3samples : MonoBehaviour
{
    [SerializeField]
    GameObject targetObject;
    [SerializeField]
    sO s;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        s.dat = transform.position;
    }
}
