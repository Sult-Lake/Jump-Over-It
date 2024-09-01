using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public Transform player;
    public float smoothMove = 0.125f;



    void LateUpdate()
    {
        Vector3 Position = new Vector3(player.position.x,player.position.y,10);
        Vector3 Cameraposition = Vector3.Lerp(transform.position,Position,smoothMove);
        transform.position = Cameraposition;
    }
}
