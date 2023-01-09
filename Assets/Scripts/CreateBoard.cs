using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{

    public Color lightSquare;
    public Color darkSquare;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateGraphicalBoard()
    {
        for(int file = 0; file < 8; file++)
        {
            for(int rank = 0; rank < 8; rank++)
            {
                bool isLightSquare = (file + rank) % 2 != 0;

                var squareColor = (isLightSquare) ? lightSquare : darkSquare;
                var position = new Vector2(-3.5f + file, -3.5f + rank);

                
            }
        }
    }

    void DrawBoard()
    {

    }
}
