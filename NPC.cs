using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float posX;
    // Start is called before the first frame update
    void Start()
    {
        posX = 0;
    }

    // Update is called once per frame
    void Update()
    {
        posX = 0.1f;
        transform.position = new Vector3(20,posX,25);

    }
}


