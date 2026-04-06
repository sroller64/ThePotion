/*****************************************************************************
// File Name : PlayerDeath.cs
// Author : Shawn Roller
// Creation Date : March 26, 2026
//
// Brief Description : What happens when the player dies
*****************************************************************************/
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private bool isDead;
    [SerializeField] private float reloadDelay;
    [SerializeField] private float lowestYPos;
    public GameObject player;
    public GameObject psl;
    /// <summary>
    /// States the player is not dead when the game starts
    /// </summary>
    void Start()
    {
        isDead = false;
    }
    /// <summary>
    /// What happens when the player touches something labled danger
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            Die();
        }
    }
    /// <summary>
    /// What the games does when the player dies
    /// </summary>
    private void Die()
    {
        isDead = true;
        //player can't move
        //GetComponent<Rigidbody>().isKinematic = true;
        //isKinematic mean it is static
        //GetComponent<PlayerMovement>().enabled = true;
        //player disappear
        //GetComponent<MeshRenderer>().enabled = false;
        //Puts the player back at the start
        player.transform.position = psl.transform.position;

    }
    /// <summary>
    /// Reloads the scene when the player dies
    /// </summary>
    //private void ReloadScene()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
    /// <summary>
    /// If the player falls below the map the player dies.
    /// </summary>
    void Update()
    {
        if (transform.position.y < lowestYPos && !isDead)
        {
            Die();
        }
    }
}
