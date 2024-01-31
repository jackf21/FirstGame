using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShapeArrangement : MonoBehaviour 
{
    public GameObject[] scrambledShapes = new GameObject[4];
    [SerializeField] Transform[] shapePositions = new Transform[4];
    Vector3 shapepositionActual;

    private void Start()
    {
        GenerateRandomArray(scrambledShapes);
        for (int i = 0; i < scrambledShapes.Length; i++)
        {
            Vector3 shapepositionActual = shapePositions[i].position;
            Instantiate(scrambledShapes[i], shapepositionActual, Quaternion.identity);
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
