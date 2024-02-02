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
    [SerializeField] Transform parent;
    GameObject newObject;

    Vector3 shapepositionActual;

    Scramble scramble = new Scramble();

    private void Start()
    {
        scramble.GameObjectRandomArray(scrambledShapes);
        for (int i = 0; i < scrambledShapes.Length; i++)
        {
            Vector3 shapepositionActual = shapePositions[i].position;
            newObject = Instantiate(scrambledShapes[i], shapepositionActual, Quaternion.identity);
            newObject.transform.SetParent(parent);
        }
    }
}