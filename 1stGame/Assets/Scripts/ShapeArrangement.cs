using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShapeArrangement : MonoBehaviour 
{
    [SerializeField] int[] scrambledShapeIDs = new int[4];
    
    [SerializeField] GameObject _circle;
    //[SerializeField] GameObject _square;
    //[SerializeField] GameObject _triangle;
    //[SerializeField] GameObject _pentagon;
    
    private void Start()
    {
        for(int i = 0; i < scrambledShapeIDs.Length; i++)
        {
            scrambledShapeIDs[i] = i + 1;
        }

        GenerateRandomArray(scrambledShapeIDs);
        for (int i = 0; i < scrambledShapeIDs.Length; i++)
        {
            Console.WriteLine(scrambledShapeIDs[i]);
        }
        Instantiate(_circle, new Vector3(0f, 0f, 0f), Quaternion.identity);

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
