using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score1 = null;
    [SerializeField] private TextMeshProUGUI score2 = null;

    private void Update()
    {
        score1.text = "Score: " + GameManager.Instance.ScorePlayer1;
        score2.text = "Score: " + GameManager.Instance.ScorePlayer2;
    }
}
