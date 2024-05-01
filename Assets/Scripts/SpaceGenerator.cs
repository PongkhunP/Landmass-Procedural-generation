using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceGenerator : MonoBehaviour
{
    public static void GenerateSpace(float[,] heightMap , GameObject generateObject)
    {
        for(int x = 0; x < heightMap.GetLength(0); x++)
        {
            for(int y = 0; y < heightMap.GetLength(1); y++)
            {
                Instantiate(generateObject , new Vector3(x , 0 , y) ,Quaternion.identity);
            }
        }
    }
}
