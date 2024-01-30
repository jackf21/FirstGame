using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Slider timer;
    [SerializeField] float sliderTime;
    [SerializeField] float increasingTime;

    private void Update()
    {
        increasingTime += Time.deltaTime;
        timer.value = Mathf.Lerp(0, 1, increasingTime / sliderTime);
    }
}
