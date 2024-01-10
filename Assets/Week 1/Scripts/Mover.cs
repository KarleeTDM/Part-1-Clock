using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Horizontal");
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
}
