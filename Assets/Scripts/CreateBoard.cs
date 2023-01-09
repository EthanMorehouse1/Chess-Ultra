using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    public GameObject lightSquare;
    public GameObject darkSquare;
    public GameObject riverSquare;
    // Start is called before the first frame update
    void Start()
    {
        CreateGraphicalBoard();
    }

    void CreateGraphicalBoard()
    {
        for(int file = 0; file < 8; file++)
        {
            for(int rank = 0; rank < 9; rank++)
            {
                bool isLightSquare = (file + rank) % 2 != 0;
                var position = new Vector2(-3.5f + file, -3.5f + rank);
                if(rank == 4)
                {
                    Instantiate(riverSquare, position, Quaternion.identity);
                }
                else if(rank != 4 && isLightSquare == false)
                {
                    Instantiate(darkSquare, position, Quaternion.identity);
                }
                else
                {
                    Instantiate(lightSquare, position, Quaternion.identity);
                }
            }
        }
    }
}
