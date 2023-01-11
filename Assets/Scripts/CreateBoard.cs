using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    public GameObject lightSquare;
    public GameObject darkSquare;
    public GameObject riverSquare;

    public GameObject whiteRook;
    public GameObject whiteKnight;
    public GameObject whiteBishop;
    public GameObject whiteQueen;
    public GameObject whiteKing;
    public GameObject whitePawn;

    public GameObject blackRook;
    public GameObject blackKnight;
    public GameObject blackBishop;
    public GameObject blackQueen;
    public GameObject blackKing;
    public GameObject blackPawn;

    public GameObject[] squares;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        CreateGraphicalBoard();
    }

    void CreateGraphicalBoard()
    {
        for(int rank = 0; rank < 9; rank++)
        {
            for(int file = 0; file < 8; file++)
            {
                bool isLightSquare = (file + rank) % 2 != 0;
                var position = new Vector2(-3.5f + file, -3.5f + rank);
                if(rank == 4)
                {
                    Instantiate(riverSquare, position, Quaternion.identity);
                    CreatePieces(position);

                    squares[i] = riverSquare;
                    i++;
                }
                else if(rank != 4 && isLightSquare == false)
                {
                    Instantiate(darkSquare, position, Quaternion.identity);
                    CreatePieces(position);

                    squares[i] = darkSquare;
                    i++;
                }
                else
                {
                    Instantiate(lightSquare, position, Quaternion.identity);
                    CreatePieces(position);

                    squares[i] = lightSquare;
                    i++;
                }
            }
        }
    }

    void CreatePieces(Vector2 pos)
    {
        if(i == 0 || i == 7)
        {
            Instantiate(whiteRook, pos, Quaternion.identity);
        }
        if(i == 1 || i == 6)
        {
            Instantiate(whiteKnight, pos, Quaternion.identity);
        }
        if (i == 2 || i == 5)
        {
            Instantiate(whiteBishop, pos, Quaternion.identity);
        }
        if (i == 3)
        {
            Instantiate(whiteQueen, pos, Quaternion.identity);
        }
        if (i == 4)
        {
            Instantiate(whiteKing, pos, Quaternion.identity);
        }
        if(i >= 8 && i <= 15)
        {
            Instantiate(whitePawn, pos, Quaternion.identity);   
        }
        if (i == 64 || i == 71)
        {
            Instantiate(blackRook, pos, Quaternion.identity);
        }
        if (i == 65 || i == 70)
        {
            Instantiate(blackKnight, pos, Quaternion.identity);
        }
        if (i == 66 || i == 69)
        {
            Instantiate(blackBishop, pos, Quaternion.identity);
        }
        if (i == 67)
        {
            Instantiate(blackQueen, pos, Quaternion.identity);
        }
        if (i == 68)
        {
            Instantiate(blackKing, pos, Quaternion.identity);
        }
        if (i >= 56 && i <= 63)
        {
            Instantiate(blackPawn, pos, Quaternion.identity);
        }
    }
}
