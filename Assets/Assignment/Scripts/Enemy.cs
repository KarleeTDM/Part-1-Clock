using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float jump;
    public float speed = 360;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, -speed * Time.deltaTime);
        transform.Translate(-5 * Time.deltaTime, 0, 0);
    }
}
