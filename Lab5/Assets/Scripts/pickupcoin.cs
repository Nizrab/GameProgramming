using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupcoin : MonoBehaviour
{
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Coin was picked up");
            pickup();
        }
    }
    public void pickup()
    {
        score++;
        setText();
    }
    private void setText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}
