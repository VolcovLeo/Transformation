using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    void Update()
    {
        transform.position += _movementDirection * Time.deltaTime;
    }
}
