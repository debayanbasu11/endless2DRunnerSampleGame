using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    private void Update(){
        scoreDisplay.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Obstacle")){
            // Increase score by 1!
            score++;
            Debug.Log(score);
            Destroy(other.gameObject,0.9f);
        }
    }
}
