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
            Debug.LogWarning("MoveController�� �����ϴ�!");
        }
    }

    void Update()
    {
        Vector2 moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector2.up; // ���� �̵�
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector2.down; // �Ʒ��� �̵�
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector2.left; // ���� �̵�
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector2.right; // ������ �̵�
        }

        if (moveController != null)
        {
            moveController.Move(moveDirection);
        }
    }
}
