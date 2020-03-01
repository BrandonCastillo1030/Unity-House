using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFloor : MonoBehaviour
{
    public GameObject Cube;
    int floorX = 0;
    int floorY = 1;
    int floorZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(floorX, floorY, floorZ), Quaternion.identity);
                floorZ += 1;
            }
            floorZ = 0;
            floorX += 1;
        }
    }
}
