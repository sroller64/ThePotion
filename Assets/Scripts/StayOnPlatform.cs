/*****************************************************************************
// File Name : StayOnPlatform.cs
// Author : Shawn Roller
// Creation Date : March 26, 2026
//
// Brief Description : What happen when the player is on a moving object
*****************************************************************************/
using UnityEngine;

public class StayOnPlatoform : MonoBehaviour
{
    /// <summary>
    /// What happens when the moving object has the player on it. 
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
            //childs the plaer to the platform => moves with the platform
        }
    }
    /// <summary>
    /// What happen when the player gets off the moving platforms.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
            //orphans the player => player is free
        }
    }
}
