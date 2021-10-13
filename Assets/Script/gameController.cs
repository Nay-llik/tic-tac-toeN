using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public enum TurnState
    {
        None=0,
        PlayerOne=1,
        PlayerTwo=2
    };

    public TurnState Turn;
    public List<int> playerOneChecks;
    public List<int> playerTwoChecks;

    // Start is called before the first frame update
    void Start()
    {
        Turn = TurnState.PlayerOne;
    }
    public void changeTurn(int _id)
    {
        if (Turn == TurnState.PlayerOne)
        {
            playerOneChecks.Add(_id);
            Turn = TurnState.PlayerTwo;
        }
        else if (Turn == TurnState.PlayerTwo) 
        {
            playerTwoChecks.Add(_id);
            Turn = TurnState.PlayerOne;
        }
        checkWin();
    }

    void checkWin()
    {
        if((playerOneChecks.Contains(1) && playerOneChecks.Contains(5) && playerOneChecks.Contains(9))||((playerOneChecks.Contains(1) && playerOneChecks.Contains(2) && playerOneChecks.Contains(3)))|| ((playerOneChecks.Contains(1) && playerOneChecks.Contains(4) && playerOneChecks.Contains(7)))|| ((playerOneChecks.Contains(7) && playerOneChecks.Contains(8) && playerOneChecks.Contains(9)))|| ((playerOneChecks.Contains(7) && playerOneChecks.Contains(5) && playerOneChecks.Contains(3)))|| ((playerOneChecks.Contains(3) && playerOneChecks.Contains(6) && playerOneChecks.Contains(9)))||((playerOneChecks.Contains(4) && playerOneChecks.Contains(5) && playerOneChecks.Contains(6))) || ((playerOneChecks.Contains(2) && playerOneChecks.Contains(5) && playerOneChecks.Contains(8))))
        {
            Debug.Log("stop le 1 a win en fait");
        }
        else if ((playerTwoChecks.Contains(1) && playerTwoChecks.Contains(5) && playerTwoChecks.Contains(9)) || ((playerTwoChecks.Contains(1) && playerTwoChecks.Contains(2) && playerTwoChecks.Contains(3))) || ((playerTwoChecks.Contains(1) && playerTwoChecks.Contains(4) && playerTwoChecks.Contains(7))) || ((playerTwoChecks.Contains(7) && playerTwoChecks.Contains(8) && playerTwoChecks.Contains(9))) || ((playerTwoChecks.Contains(7) && playerTwoChecks.Contains(5) && playerTwoChecks.Contains(3))) || ((playerTwoChecks.Contains(3) && playerTwoChecks.Contains(6) && playerTwoChecks.Contains(9)))||((playerTwoChecks.Contains(4) && playerTwoChecks.Contains(5) && playerTwoChecks.Contains(6))) || ((playerTwoChecks.Contains(2) && playerTwoChecks.Contains(5) && playerTwoChecks.Contains(8))))
        {
            Debug.Log("stop le 2 a win en fait");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
