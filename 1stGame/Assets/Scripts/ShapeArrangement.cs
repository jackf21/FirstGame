using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShapeArrangement : MonoBehaviour 
{
    [SerializeField] GameObject[] scrambledShapeIDs = new GameObject[4];
    
    private void Start()
    {
        GenerateRandomArray(scrambledShapeIDs);
        for (int i = 0; i < scrambledShapeIDs.Length; i++)
        {
            Console.WriteLine(scrambledShapeIDs[i]);
        }
    }

    private GameObject[] GenerateRandomArray(GameObject[] arrayToShuffle)
    {
        for (int i = arrayToShuffle.Length - 1; i >= 0; i--)
        {
            var k = RandomNumberGen(i + 1);
            var value = arrayToShuffle[k];
            arrayToShuffle[k] = arrayToShuffle[i];
            arrayToShuffle[i] = value;
        }

        return arrayToShuffle;
    }

    private int RandomNumberGen(int max)
    {
        int random = UnityEngine.Random.Range(0, max);
        return random;
    }
}
