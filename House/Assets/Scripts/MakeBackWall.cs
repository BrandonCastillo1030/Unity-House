using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBackWall : MonoBehaviour
{
    public GameObject Cube;
    int backWallX = 0;
    int backWallY = 1;
    int backWallZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(backWallX, backWallY, backWallZ), Quaternion.identity);
                backWallX += 1;
            }
            backWallX = 0;
            backWallY += 1;
        }
    }
}
