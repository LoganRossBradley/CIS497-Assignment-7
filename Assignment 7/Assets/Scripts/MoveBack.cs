/* * Logan Ross
 * * MoveBack.cs 
 * * Assignment 7 
 * * move player back command
 */

using UnityEngine;
using System.Collections;

public class MoveBack : MonoBehaviour, Command
{
    private PlayerController player;
    public MoveBack(PlayerController passedPlayer)
    {
        player = passedPlayer;
    }

    public void execute()
    {
        player.moveBack();
    }
}