using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    public void Move(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            float speed = playerController.GetSpeed();
            transform.position += (Vector3)direction * speed * Time.deltaTime;
        }
    }
}
