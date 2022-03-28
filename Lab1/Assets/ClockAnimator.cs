using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
    private const float hoursToDegrees = 360f / 12f, minutesToDegrees = 360f / 60f, secondsToDegrees = 360f / 60f;
    public Transform hours, minutes, seconds;
    public bool anolog;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (anolog)
        {
            const float secondsToDegrees = 360f / 60000f;
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour* -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute* -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second* -secondsToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, (time.Second* 1000 + time.Millisecond) * - secondsToDegrees);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
        }
    }
}