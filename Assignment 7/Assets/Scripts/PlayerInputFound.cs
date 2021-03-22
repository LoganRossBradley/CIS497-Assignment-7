/* * Logan Ross
 * * PlayerInputFound.cs 
 * * Assignment 7 
 * * went unused
 */

using UnityEngine;
using System.Collections;


public class PlayerInputFound : MonoBehaviour
{
    Command storedCommand;

    public PlayerInputFound(Command passedCommand)
    {
        storedCommand = passedCommand;
    }

    public void inputFound()
    {
        storedCommand.execute();
    }
}
