using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceMove : MonoBehaviour
{
    public GameObject selectedSpace;
    public float spaceInArray;
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

            if (hit.collider != null) 
            {
                selectedSpace = hit.collider.gameObject;

                
                if(selectedSpace.CompareTag("PawnWhite"))
                {

                }
                else if(selectedSpace.CompareTag("PawnBlack"))
                {

                }
                else if(selectedSpace.CompareTag("Rook"))
                {
                    
                }
                else if(selectedSpace.CompareTag("Bishop"))
                {
                    
                }
                else if(selectedSpace.CompareTag("Knight"))
                {
                    
                }
                else if(selectedSpace.CompareTag("King"))
                {
                    
                }
                else if(selectedSpace.CompareTag("Queen"))
                {
                    
                }

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
