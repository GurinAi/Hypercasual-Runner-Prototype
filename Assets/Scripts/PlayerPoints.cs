using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    private int playerScore = 20;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = playerScore.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLUS_2"))
        {
            playerScore += 2;
            other.gameObject.SetActive(false);
            scoreText.text = playerScore.ToString();
            checkCurrentScore();
        }
        else if(other.CompareTag("MINUS_2"))
        {
            playerScore -= 2;
            other.gameObject.SetActive(false);
            scoreText.text = playerScore.ToString();
            checkCurrentScore();
        }
    }
    void checkCurrentScore() 
    {
        if (playerScore <= 0)
        {
            Debug.Log("LOSE");
        }
        else if(playerScore < 20)
        {
            Debug.Log("HOMELESS");
        }
        else if (playerScore >= 20 && playerScore < 60)
        {
            Debug.Log("POOR");
        }
        else if (playerScore >= 60 && playerScore < 100)
        {
            Debug.Log("WEALTHY");
        }
        else if (playerScore >= 100 && playerScore < 140)
        {
            Debug.Log("RICH");
        }
        else
        {
            Debug.Log("MILLIONER");
        }
    }
}
