using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField]
    private string message;
    [SerializeField]
    private TMPro.TextMeshProUGUI gameOverText;

    private void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
            gameOverText.SetText(message);
        }
    }
}
