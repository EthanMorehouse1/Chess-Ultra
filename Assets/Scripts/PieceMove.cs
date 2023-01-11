using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            Debug.Log("Mouse Clicked");

            if (hit.collider != null) 
            {
                
            Debug.Log("Something was clicked!");
            }
        }
    }

    void PawnMove()
    {

    }

    void BishopMove()
    {

    }

    void KnightMove()
    {

    }

    void RookMove()
    {

    }

    void QueenMove()
    {

    }

    void KingMove()
    {

    }
}
