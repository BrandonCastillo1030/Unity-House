using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject Cube;
    int doorX = 1;
    int doorY = 1;
    int doorZ = 6;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Instantiate(Cube, new Vector3(doorX, doorY, doorZ), Quaternion.identity);
                doorX += 1;
            }
            doorX = 1;
            doorY += 1;
        }
    }
}
