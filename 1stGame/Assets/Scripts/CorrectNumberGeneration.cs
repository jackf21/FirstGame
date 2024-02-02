using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CorrectNumberGeneration : MonoBehaviour
{
    [Header("In Scene")]
    [SerializeField] GameObject initialPanel;
    [SerializeField] GameObject finalPanel;
    [SerializeField] TMP_Text numberText;

    [Header("New Arrays")]
    GameObject[] initialPanelNew = new GameObject[4];
    GameObject[] finalPanelNew = new GameObject[4];

    int[] textPositions = new int[4];

    private void Start()
    {
        initialPanel = GameObject.Find("Initial Panel");
        finalPanel = GameObject.Find("Final Panel");
    }

    void Update()
    {
        //Loading arrays grabbed from scene into arrays in the script
        for(int i = 0; i < initialPanelNew.Length; i++)
        {
            initialPanelNew[i] = initialPanel.GetComponent<ShapeArrangement>().scrambledShapes[i];
        }

        for(int i = 0; i < finalPanelNew.Length; i++)
        {
            finalPanelNew[i] = finalPanel.GetComponent<ShapeArrangement>().scrambledShapes[i];
        }

        //Checking each shape in the initial pannel for its counterpart in the final pannel
        for (int i = 0; i < initialPanelNew.Length; i++)
        {
            for(int j = 0;j < finalPanelNew.Length; j++)
            {
                if (initialPanelNew[i].tag == finalPanelNew[j].tag)
                {
                    textPositions[i] = j + 1; //Saves the numerical position of the shape in the final array in the
                }
            }
        }

        numberText.text = (textPositions[0] + " " + textPositions[1] + " " + textPositions[2] + " " + textPositions[3]);
    }
}
