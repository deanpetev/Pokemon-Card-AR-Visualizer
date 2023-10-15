using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Vuforia;

public class ButtonBehavior : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0f, 100.0f * Time.deltaTime, 0f)); //will make the image rotate on the card
        }
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0f, -100.0f * Time.deltaTime, 0f)); //will make the image rotate on the card
        }
    }
}
