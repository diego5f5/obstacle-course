using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    float xValue = 0;
    float zValue = 0;

    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        xValue = moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        zValue = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(xValue, 0, zValue);
    }
}
