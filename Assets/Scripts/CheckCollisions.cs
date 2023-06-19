using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCollisions : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            //Debug.Log("Coin collected!..");
            AddCoin();
            //Destroy(other.gameObject);
            other.transform.parent.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER!");

            Clear();

            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position = new Vector3(0, 0.279f, -11.15f);
        }
    }

    public void AddCoin()
    {
        score++;
        CoinText.text = "Score: " + score.ToString();
    }

    void Clear()
    {
        score = 0;
        CoinText.text = "Score: " + score.ToString();
    }
}
