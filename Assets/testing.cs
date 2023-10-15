using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    public float movementspeed;
    void OnEnable()
    {
        Lean.Touch.LeanTouch.OnFingerTap += HandleFingerTap;
    }

    void OnDisable()
    {
        Lean.Touch.LeanTouch.OnFingerTap -= HandleFingerTap;
    }

    void HandleFingerTap(Lean.Touch.LeanFinger finger)
    {
        transform.position = Vector3.Lerp(transform.position, finger.LastScreenPosition, movementspeed);
        Debug.Log("You just tapped the screen with finger " + finger.Index + " at " + finger.ScreenPosition);
    }
}
