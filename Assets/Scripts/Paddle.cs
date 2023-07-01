using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private Transform floor = null;

    void Start()
    {
        
    }

    void Update()
    {
        float dir = Input.GetAxis("Horizontal");
        float xMax = floor.localScale.x * 10f * 0.5f - transform.localScale.x * 0.5f;   // die Hälfte der Breite des Fields - die Hälfte des Paddles
        float xPos = transform.position.x + speed * dir * Time.deltaTime;
        float clampedX = Mathf.Clamp(xPos, -xMax, xMax);

        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
