using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //will rotate the pokemon right
        {
            transform.Rotate(new Vector3(0f, 100.0f * Time.deltaTime, 0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow)) //will rotate the pokemon left
        {
            transform.Rotate(new Vector3(0f, -100.0f * Time.deltaTime, 0f));
        }
    }
}
