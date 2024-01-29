using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShapeArrangement : MonoBehaviour 
{
    int[] scrambledShapeIDs = new int[4];

    private void Start()
    {
        foreach (int i in scrambledShapeIDs)
        {
            scrambledShapeIDs[i] = i;
        }

        GenerateRandomArray(scrambledShapeIDs);
        foreach (int i in scrambledShapeIDs)
        {
            Console.WriteLine(scrambledShapeIDs[i]);
        }
    }

    public int[] GenerateRandomArray(int[] arrayToShuffle)
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
