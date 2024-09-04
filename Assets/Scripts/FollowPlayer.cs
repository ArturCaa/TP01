using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -8);

    void LateUpdate()
    {
        //Follow the player
        transform.position = player.transform.position + offset;
    }
}
