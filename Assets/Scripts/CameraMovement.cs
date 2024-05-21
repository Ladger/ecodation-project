using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform playerCar;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = playerCar.position - transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerCar.position - offset;
    }
}
