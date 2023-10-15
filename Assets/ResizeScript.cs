using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale += new Vector3(.0005f, .0005f, .0005f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localScale -= new Vector3(.0005f, .0005f, .0005f);
        }
    }
}
