using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;

    private void Start()
    {
        movementSpeed = FindObjectOfType<CarSpawner>().getCarSpeed();
    }

    // Start is called before the first frame update
    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveAmount = movementSpeed * Time.deltaTime;

        transform.Translate(0, 0, -moveAmount, Space.World);
    }

    public float getMovementSpeed() { return movementSpeed; }
}
