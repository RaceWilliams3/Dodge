using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool playerDead = false;

    private float score;

    public TMP_Text scoreText;
    public GameObject deathText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerDead)
        {
            scoreText.text = Time.time.ToString("0");
            score = Time.time;
        } else
        {
            scoreText.text = score.ToString("0");
        }
        

        if (playerDead)
        {
            deathText.active = true;
        }
    }
}
