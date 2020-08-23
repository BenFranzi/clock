using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform;
    public Transform minutesTransform;
    public Transform secondsTransform;
    public Transform sunTransform;

    private void Awake()
    {
        Debug.Log((float)DateTime.Now.TimeOfDay.TotalHours);
    }

    void Update()
    {   
        hoursTransform.localRotation = Quaternion.Euler(0f, (float)DateTime.Now.TimeOfDay.TotalHours * 30f, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, (float)DateTime.Now.TimeOfDay.TotalMinutes * 6f, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, (float)DateTime.Now.TimeOfDay.TotalSeconds * 6f, 0f);

    
        sunTransform.localRotation = Quaternion.Euler((float) DateTime.Now.TimeOfDay.TotalHours * 15f - 90f, 0f, 0f);
    }
}
