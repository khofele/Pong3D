using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float xMax = 1;
    [SerializeField] private float zMax = 1;

    private Vector3 velocity = Vector3.zero;
    private Vector3 spawnPosition = new Vector3(0, 0.5f, 0);

    void Start()
    {
        velocity = new Vector3(0, 0, zMax);
        gameObject.GetComponent<Renderer>().material = GameManager.Instance.DefaultMaterial;
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Paddle"))
        {
            float maxDistance = 0.5f * other.transform.localScale.x + 0.5f * transform.localScale.x;
            float distance = transform.position.x - other.transform.position.x;
            float normalizedDistance = distance / maxDistance;
            velocity = new Vector3(normalizedDistance * xMax, velocity.y, -velocity.z);
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if(other.transform.CompareTag("Wall"))
        {
            velocity = new Vector3(-velocity.x, velocity.y, velocity.z);
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if(other.transform.CompareTag("TriggerLeft"))
        {
            ResetBall();
            GameManager.Instance.ScorePlayer2++;
        }
        else if(other.transform.CompareTag("TriggerRight"))
        {
            ResetBall();
            GameManager.Instance.ScorePlayer1++;
        }
    }

    private void ResetBall()
    {
        transform.position = spawnPosition;
    }
}
