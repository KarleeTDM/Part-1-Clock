using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force;
    public float jump;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(new Vector2(rigidbody.velocity.x, jump));
            Debug.Log("The player has jumped.");
        }
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("The player has landed.");
    }
}
