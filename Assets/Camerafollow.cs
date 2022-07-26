using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3  T;
    // Update is called once per frame
    void Update()
    {
        transform.position=target.position+T;
    }
}
