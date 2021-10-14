using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     Rigidbody2D rigidBody;
    [SerializeField]float speedMultiplier;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //get input
        float horizontalInput = Input.GetAxisRaw("Horizontal") * speedMultiplier;
        rigidBody.velocity = new Vector2(horizontalInput, rigidBody.velocity.y);
    }


}
