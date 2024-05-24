using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSideSpeed = 5f;
    [SerializeField] private Transform ground;
    [SerializeField] GameObject gameOverScreen;

    List<Transform> lanes = new List<Transform>();
    private int laneIndex = 1;
    private bool isMoving;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in ground)
        {
            lanes.Add(t);
        }

        isMoving = false;
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                MoveSide(-1);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                MoveSide(1);
            }
        }

        if (isMoving)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, playerSideSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                transform.position = targetPosition;
                isMoving = false;
            }
        }
    }

    void MoveSide(int direction)
    {
        int newLaneIndex = Mathf.Clamp(laneIndex + direction, 0, lanes.Count - 1);
        if (newLaneIndex != laneIndex)
        {
            laneIndex = newLaneIndex;
            targetPosition.x = lanes[laneIndex].position.x;
            isMoving = true;
        }
    }

    public int getLaneIndex() { return laneIndex; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            if (collision.transform.CompareTag("Obstacle"))
            {
                gameOverScreen.SetActive(true);
            }
        }
    }
}
