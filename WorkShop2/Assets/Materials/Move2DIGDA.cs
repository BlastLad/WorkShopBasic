using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2DIGDA : MonoBehaviour
{
    Vector2 move;
    Rigidbody2D rigidbody2d;

    float playerSpeed = 9f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");//Left and Right Arrow Keys
        move.y = Input.GetAxisRaw("Vertical");//Up and Down Arrow Keys 


        transform.position += (Vector3)move * playerSpeed * Time.deltaTime;//Moving the player
        

    }


}
