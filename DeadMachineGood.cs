using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadMachineGood : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col != null)
        {
            Destroy(col.gameObject);
        }
    }
}
