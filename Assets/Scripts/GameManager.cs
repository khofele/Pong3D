using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // To Do Optional: Gameoverlogik, Menü, Kamera verändern
    [SerializeField] private static int scorePlayer1 = 0;
    [SerializeField] private static int scorePlayer2 = 0;
    [SerializeField] private Material defaultMaterial = null;

    private static GameManager instance = null;

    public static GameManager Instance
    {
        get => instance;
    }

    public int ScorePlayer1
    {
        get => scorePlayer1;
        set
        {
            scorePlayer1 = value;
        }
    }

    public int ScorePlayer2
    {
        get => scorePlayer2;
        set
        {
            scorePlayer2 = value;
        }
    }

    public Material DefaultMaterial
    {
        get => defaultMaterial;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
