using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private MoveController moveController;

    void Start()
    {
        moveController = GetComponent<MoveController>();
        if (moveController == null)
        {
            Debug.LogWarning("MoveController가 없습니다!");
        }
    }

    void Update()
    {
        Vector2 moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector2.up; // 위쪽 이동
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector2.down; // 아래쪽 이동
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector2.left; // 왼쪽 이동
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector2.right; // 오른쪽 이동
        }

        if (moveController != null)
        {
            moveController.Move(moveDirection);
        }
    }
}
