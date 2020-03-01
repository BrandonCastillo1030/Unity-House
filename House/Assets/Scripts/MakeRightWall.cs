using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRightWall : MonoBehaviour
{
    public GameObject Cube;
    int rightWallX = 0;
    int rightWallY = 1;
    int rightWallZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
      for (int i =0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(rightWallX, rightWallY, rightWallZ), Quaternion.identity);
                rightWallZ += 1;
            }
            rightWallZ = 0;
            rightWallY += 1;
        }  
    }

}
