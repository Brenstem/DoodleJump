using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] GameObject block;
    [SerializeField] float minY;
    [SerializeField] float maxY;
    [SerializeField] float levelWidth;
    
    void Start()
    {
        Vector2 startPos = new Vector2();

        for (int i = 0; i < 200; i++)
        {
            startPos.y += Random.Range(minY, maxY);
            startPos.x = Random.Range(-levelWidth / 2, levelWidth / 2);
            Instantiate(block, startPos, Quaternion.identity);

            if ()
            {

            }
        }
    }
}
