/* * Logan Ross
 * * MoveRight.cs 
 * * Assignment 7 
 * * move player Right command
 */

using UnityEngine;
using System.Collections;


public class MoveRight : MonoBehaviour, Command
{
    private PlayerController player;
    public MoveRight(PlayerController passedPlayer)
    {
        player = passedPlayer;
    }

    public void execute()
    {
        player.moveRight();
    }
}
