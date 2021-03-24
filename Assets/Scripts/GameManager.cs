using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text distance;

    private GameObject player;
    private GameObject flag;


    void Start()
    {
        this.player = GameObject.FindGameObjectWithTag("Player");
        this.flag = GameObject.FindGameObjectWithTag("Flag");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.player.transform.position.x;

        if (length > 0.5f)
            distance.text = "목표 지점까지 " + length.ToString("F2") + "m";
        else if (length <= 0.5f && length >= -0.5f)
            distance.text = "승리했다!";
        else
            distance.text = "gaMeover";
    }
}
