using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeLeftWall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube;
    int leftWallX = 5;
    int leftWallY = 1;
    int leftWallZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(leftWallX, leftWallY, leftWallZ), Quaternion.identity);
                leftWallZ += 1;
            }
            leftWallZ = 0;
            leftWallY += 1;
        }
    }
}