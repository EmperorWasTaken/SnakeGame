using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    public GameObject bean_Pickup;

    private float min_X = -6.5f, max_X = 6.5f, min_Y = -1.8f, max_Y = 11f;
    private float z_Pos = -0.36f;

    private Text score_Text;
    private int scoreCount;
    
    public TMP_Text pointsText;
    public int pointCount = 0;
    
    void Awake()
    {
        MakeInstance();
    }

    private void Start()
    {
        score_Text = GameObject.Find("Score").GetComponent<Text>();
        
        Invoke("StartSpawning", 0.5f);
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void StartSpawning()
    {
        StartCoroutine(SpawnPickUps());
    }

    public void CancelSpawning()
    {
        CancelInvoke("StartSpawning");
    }

    IEnumerator SpawnPickUps()
    {
        yield return new WaitForSeconds(Random.Range(1f, 1.5f));
        if (Random.Range(0, 10) >= 2)
        {
            Instantiate(bean_Pickup, new Vector3(Random.Range(min_X, max_X), Random.Range(min_Y, max_Y), z_Pos), Quaternion.identity);
        }
        Invoke("StartSpawning", 0f);
    }

    public void IncreaseScore()
    {
        scoreCount++;
        pointCount += 1;
        score_Text.text = "Score: " + scoreCount;
        pointsText.text = String.Format("{0}", pointCount);
    }
}
