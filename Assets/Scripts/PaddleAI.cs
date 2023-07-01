using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleAI : MonoBehaviour
{
    [SerializeField] private Transform ball = null;

    void Update()
    {
        transform.position = new Vector3(ball.position.x, transform.position.y, transform.position.z);
    }
}
