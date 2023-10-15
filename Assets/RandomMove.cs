using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMove : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float myX = transform.position.x;
        float myZ = transform.position.z;

        float xPos = myX + Random.Range(myX - .005f, myX + .005f);
        float Zpos = myZ + Random.Range(myZ - .005f, myZ + .005f);

        if (Input.GetKey(KeyCode.U)) //will rotate the pokemon right
        {
            transform.localPosition = new Vector3(xPos, transform.position.y, Zpos);
        }
    }
}
