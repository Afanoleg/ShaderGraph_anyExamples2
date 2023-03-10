using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    float speed;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
