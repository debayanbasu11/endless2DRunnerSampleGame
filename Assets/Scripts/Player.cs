using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight, minHeight;
    public int health = 3;

    public GameObject effect;
    public Text healthDisplay;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthDisplay.text = health.ToString();

        if(health <= 0){
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight){
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight){
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }
}
