/* * Logan Ross
 * * MoveLeft.cs 
 * * Assignment 7 
 * * move player left command
 */

using UnityEngine;
using System.Collections;

    public class MoveLeft : MonoBehaviour, Command
    {
    private PlayerController player;
        public MoveLeft(PlayerController passedPlayer)
    {
        player = passedPlayer;
    }

    public void execute()
    {
        player.moveLeft();
    }
}