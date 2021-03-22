/* * Logan Ross
 * * GameManager.cs 
 * * Assignment 7 
 * * checks for player input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerObject playerObject;
    public GameObject player;
    public PlayerController pc;
    public Stack<char> prevMoves;

    MoveLeft leftCommand;
    MoveRight rightCommand;
    MoveBack backCommand;
    MoveForward forwardCommand;

    private void Start()
    {
        prevMoves = new Stack<char>();
        pc = new PlayerController(player);

        leftCommand = new MoveLeft(pc);
        rightCommand = new MoveRight(pc);
        backCommand = new MoveBack(pc);
        forwardCommand = new MoveForward(pc);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftCommand.execute();
            prevMoves.Push('A');
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            backCommand.execute();
            prevMoves.Push('S');
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            rightCommand.execute();
            prevMoves.Push('D');
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            forwardCommand.execute();
            prevMoves.Push('W');
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void undoMove()
    {
        if(prevMoves.Count == 0)
        {
            Debug.Log("No previous moves");
            return;
        }

        char lastMove = prevMoves.Pop();

        if(lastMove == 'A')
        {
            rightCommand.execute();
        }
        else if (lastMove == 'S')
        {
            forwardCommand.execute();
        }
        else if (lastMove == 'D')
        {
            leftCommand.execute();
        }
        else if (lastMove == 'W')
        {
            backCommand.execute();
        }
    }
}
