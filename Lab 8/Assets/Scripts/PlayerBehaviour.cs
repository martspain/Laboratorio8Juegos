﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject text;
    public GameObject disco;
    public GameObject themeSong;
    public GameObject discoSong;
    public GameObject winBanner;
    private Text info;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        if (text)
            info = text.GetComponent<Text>();

        if (disco)
            disco.SetActive(false);

        if (discoSong)
            discoSong.SetActive(false);

        if (winBanner)
            winBanner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Note") && hitInfo.distance <= 3.0f)
                {
                    Destroy(hitInfo.collider.gameObject);
                    score += 1;
                }
            }
        }

        if (text)
            info.text = "Score: " + score.ToString();

        if (score == 8) 
        {
            if(disco)
                disco.SetActive(true);

            if (themeSong)
                themeSong.SetActive(false);

            if (discoSong)
                discoSong.SetActive(true);

            if (winBanner)
                winBanner.SetActive(true);
        }
            
    }
}
