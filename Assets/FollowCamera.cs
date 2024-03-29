using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    // this things position (camera) should be the same as the car's position
    // need to create a reference for anything other than this game object's transform.

    [SerializeField] GameObject thingToFollow;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
