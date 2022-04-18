using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float jumppForce = 1f;

    float horizontalMovement;

    private Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.postition += new Vector3(horizontalMovement, 0, 0) * Time.deltaTime * movementSpeed;

        if(Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.1f)
            
        {
            rigidbody.AddForce(new Vector2(0, jumppForce), ForceMode2D.Impulse);
        }
    }
}
