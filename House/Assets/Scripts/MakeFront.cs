using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFront : MonoBehaviour
{
    public GameObject Cube;
    int frontX = 0;
    int frontY = 1;
    int frontZ = 5;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(Cube, new Vector3(frontX, frontY, frontZ), Quaternion.identity);
                frontX += 1;
            }
            frontX = 0;
            frontY += 1;
        }
    }

}
