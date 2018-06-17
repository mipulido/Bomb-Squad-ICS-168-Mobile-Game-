using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour {

    public float totalGameTimeInSeconds;
    public Text timerText;

    public GameObject player;
    public Sprite playerExploded;

    public bool isFalling;

	// Use this for initialization
	void Start () {
        isFalling = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFalling)
        {
            if (totalGameTimeInSeconds > 0.0f)
            {
                totalGameTimeInSeconds -= Time.deltaTime;
                timerText.text = ((int)(totalGameTimeInSeconds / 60)).ToString() + ":" + ((int)(totalGameTimeInSeconds % 60)).ToString();
            }
            else
            {
                timerText.text = "You Exploded!";
                player.GetComponent<Image>().sprite = playerExploded;
            }
        }
	}
}
