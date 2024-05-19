using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<player>().collectCoin();
        Destroy(gameObject);
        print("!");
    }
}
