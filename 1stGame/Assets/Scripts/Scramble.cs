using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scramble
{    
    public GameObject[] GameObjectRandomArray(GameObject[] arrayToShuffle)
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

    public int[] IntRandomArray(int[] arrayToShuffle)
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
