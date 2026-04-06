/*****************************************************************************
// File Name : MovingObjects.cs
// Author : Shawn Roller
// Creation Date : March 26, 2026
//
// Brief Description : Makes an object moves with movepoints
*****************************************************************************/
using UnityEngine;

public class MovingObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] movepoints;
    [SerializeField] private float speed;
    private int currentIndex;
    /// <summary>
    /// Sets the currentIndex to 0
    /// </summary>
    void Start()
    {
        currentIndex = 0;
    }
    /// <summary>
    /// Gives the objet speed and has the object follow set points.
    /// </summary>
    void Update()
    {
        //Has the object move between points and moves to the next one once it reaches the first point.
        if (Vector3.Distance(transform.position, movepoints[currentIndex].transform.position) < 0.1f)
        {
            currentIndex++;
            if (currentIndex >= movepoints.Length)
            {
                currentIndex = 0;
            }
        }
        //Give the object speed 
        transform.position = Vector3.MoveTowards(transform.position, movepoints[currentIndex].transform.position,
                speed * Time.deltaTime);
    }
}
