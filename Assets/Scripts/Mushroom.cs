/*****************************************************************************
// File Name : Mushrooms.cs
// Author : Shawn Roller
// Creation Date : March 26, 2026
//
// Brief Description : What happens when a player lands on a mushroom.
*****************************************************************************/
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField] private float bounceValue;
    /// <summary>
    /// What happens when the player lands on the mushroom.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Grabs the bounce code from the player to make the player bounce.
            collision.gameObject.GetComponent<PlayerMovement>().Bounce(bounceValue);
            
        }
    }
}
