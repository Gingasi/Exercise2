using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXERCISE3 : MonoBehaviour
{
    private float SquareImage = 100f;
    private float SpaceInBetween = 50f;
    private Vector3 nextPosition;

    void Update()
    {
        //Teleport movement
        //Movement Up
        if (Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y <= SquareImage)
        {
            nextPosition = new Vector3(transform.position.x, transform.position.y + SpaceInBetween, transform.position.z);
            transform.position = nextPosition;
        }

        //Movement Down
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y <= -SquareImage)
        {
            nextPosition = new Vector3(transform.position.x, transform.position.y - SpaceInBetween, transform.position.z);
            transform.position = nextPosition;
        }

        //Movement Right
        if (Input.GetKeyDown(KeyCode.RightArrow)&& transform.position.x <= SquareImage)
        {
            nextPosition = new Vector3(transform.position.x + SpaceInBetween, transform.position.y, transform.position.z);
            transform.position = nextPosition;
        }

        //Movement Left
        if (Input.GetKeyDown(KeyCode.LeftArrow)&& transform.position.x <= -SquareImage)
        {
            nextPosition = new Vector3(transform.position.x - SpaceInBetween, transform.position.y, transform.position.z);
            transform.position = nextPosition;
        }
    }
}
