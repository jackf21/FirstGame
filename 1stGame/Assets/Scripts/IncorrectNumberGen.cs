using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IncorrectNumberGen : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;
    int[] numText = new int[4];

    private void Start()
    {
        for (int i = 0; i < numText.Length; i++)
        {
            numText[i] = i+1;
        }
        
        GenerateRandomArray(numText);

        numberText.text = (numText[0] + " " + numText[1] + " " + numText[2] + " " + numText[3]);
    }

    private int[] GenerateRandomArray(int[] arrayToShuffle)
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
