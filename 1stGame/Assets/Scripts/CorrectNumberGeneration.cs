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
}
