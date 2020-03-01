using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimney : MonoBehaviour
{
    public GameObject Cube;
    int chimneyX = 0;
    int chimneyY = 7;
    int chimneyZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        // It took me awhile, but now I understand how nested loops work a bit more
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Instantiate(Cube, new Vector3(chimneyX, chimneyY, chimneyZ), Quaternion.identity);
                chimneyY += 1;
            }
            chimneyY = 0;
            chimneyX += 1;
        }
    }
}
