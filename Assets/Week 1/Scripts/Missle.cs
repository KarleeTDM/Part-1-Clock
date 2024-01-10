using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Missle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
