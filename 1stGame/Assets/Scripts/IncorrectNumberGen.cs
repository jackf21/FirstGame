using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IncorrectNumberGen : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;
    int[] numText = new int[4];

    Scramble scramble = new Scramble();

    private void Start()
    {
        for (int i = 0; i < numText.Length; i++)
        {
            numText[i] = i+1;
        }

        scramble.IntRandomArray(numText);

        numberText.text = (numText[0] + " " + numText[1] + " " + numText[2] + " " + numText[3]);
    }
}
