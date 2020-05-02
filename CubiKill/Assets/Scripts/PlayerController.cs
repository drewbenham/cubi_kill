using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D playerRigidBody;

    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start() {
        playerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // For animation takes in a vector to decide on States.
        Vector2 move = new Vector2(horizontal, vertical);

        // Get the position of the rigidBody collider
        Vector2 position = playerRigidBody.position;

        // how the player will move
        position = position + move * speed * Time.deltaTime;

        playerRigidBody.MovePosition(position);
    }
}
