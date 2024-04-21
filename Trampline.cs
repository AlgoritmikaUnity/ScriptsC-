using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampline : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= 5;  
    }

    public void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= 5;  
    }
}
