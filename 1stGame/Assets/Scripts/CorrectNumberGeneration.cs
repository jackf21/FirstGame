using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CorrectNumberGeneration : MonoBehaviour
{
    [Header("GameObjects")]
    [SerializeField] GameObject initialPanel;
    [SerializeField] GameObject finalPanel;
    [SerializeField] GameObject correctButton;

    [Header("ShapePositions")]
    int initialPanelPosition;
    int finalPanelPosition;

    int[] textPositions = new int[4];

    //Number = shape position in final pannel array
    //Position of number (in textPositions) = shape position in initial pannel array

    //For each element in initial pannel array find the matching one in final pannel array
    //If type of gameobject matches, the position of the compared element (+1) is saved in the textPositions array at the associated position
    //Use == (maybe compare tag if desparate)

    //Update text field after with (texPositions[0] + " " +  texPositions[1] etc)
}
