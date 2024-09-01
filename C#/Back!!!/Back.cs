using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.attachedRigidbody != null)
        {
            // 将物体的位置设置为(0, 0, 0)
            other.transform.position = Vector3.zero;
        }
    }
}
