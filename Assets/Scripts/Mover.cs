using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void PlayerMove()
    {
        float xVal = Input.GetAxis("Horizontal")* Time.deltaTime * speed;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(xVal, 0, zVal);
    }
}
