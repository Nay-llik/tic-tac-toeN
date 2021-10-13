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
        checkDiagonals();
    }

    void checkDiagonals()
    {
        if(playerOneChecks.Contains(1) && playerOneChecks.Contains(5) && playerOneChecks.Contains(9))
        {
            Debug.Log("stop le 1 a win en fait");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
