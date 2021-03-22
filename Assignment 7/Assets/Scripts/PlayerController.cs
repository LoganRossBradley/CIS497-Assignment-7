/* * Logan Ross
 * * PlayerController.cs 
 * * Assignment 7 
 * * actually moves the player
 */

using UnityEngine;
using System.Collections;


    public class PlayerController : MonoBehaviour, PlayerObject
    {
    public GameObject player;

    public PlayerController(GameObject pPlayer)
    {
        player = pPlayer;
    }
    public void moveBack()
    {
        player.transform.Translate(Vector3.back);
    }

    public void moveForward()
    {
        player.transform.Translate(Vector3.forward);
    }

    public void moveLeft()
    {
        player.transform.Translate(Vector3.left);
    }

    public void moveRight()
    {
        player.transform.Translate(Vector3.right);
    }

}
