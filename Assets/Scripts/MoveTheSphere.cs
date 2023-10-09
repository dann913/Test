using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheSphere : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, rotationSpeed, 0f) * Time.deltaTime);
    }
}
