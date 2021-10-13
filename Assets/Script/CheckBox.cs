using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CheckBox : MonoBehaviour,IPointerClickHandler
{
    public gameController Game;
    public Sprite Cross;
    public Sprite Circle;
    public int ID;

    // Start is called before the first frame update
    void Start()
    {
        Game = FindObjectOfType<gameController>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Game.Turn == gameController.TurnState.PlayerOne)
        {
            GetComponent<Image>().sprite = Cross;
            GetComponent<Image>().color = Color.white;
            Game.changeTurn(ID);
        }
        else if (Game.Turn == gameController.TurnState.PlayerTwo)
        {
            GetComponent<Image>().sprite = Circle;
            GetComponent<Image>().color = Color.white;
            Game.changeTurn(ID);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
