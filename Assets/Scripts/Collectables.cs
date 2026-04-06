/*****************************************************************************
// File Name : Collectables.cs
// Author : Shawn Roller
// Creation Date : March 13, 2026
//
// Brief Description : Everything to do with the collectables
*****************************************************************************/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectables : MonoBehaviour
{
    private int keys;
    /// <summary>
    /// Sets how many keys you start with.
    /// </summary>
    void Start()
    {
        keys = 0;
    }
    /// <summary>
    /// What happens when the player intreacts with each item.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ingrediant"))
        {
            //Moves to the next level when you collect it.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Key"))
        {
            keys++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Gate"))
        {
            if (keys > 0)
            {
                keys--;
                Destroy(collision.gameObject);
            }
        }
    }
}