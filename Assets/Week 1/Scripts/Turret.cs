using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float KeyboardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward, KeyboardInput * speed * Time.deltaTime);
    }
}
