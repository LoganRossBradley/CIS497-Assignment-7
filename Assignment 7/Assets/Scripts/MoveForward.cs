/* * Logan Ross
 * * MoveForward.cs 
 * * Assignment 7 
 * * move player forward command
 */

using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour, Command
{
    private PlayerController player;
    public MoveForward(PlayerController passedPlayer)
    {
        player = passedPlayer;
    }

    public void execute()
    {
        player.moveForward();
    }
}