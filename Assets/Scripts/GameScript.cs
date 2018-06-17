using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GameScript : NetworkBehaviour {
    // Timer
    public GameObject timer;
    public Text timerText;

    // Player Sprite
    public GameObject player;

    // Buttons
    public GameObject[] buttons;

    // Game Parameters
    [SyncVar]
    public bool greenButtonData, redButtonData, blueButtonData, yellowButtonData;

    private int playerNumber;

	// Use this for initialization
	void Start () {
        if (isServer)
        {
            playerNumber = 1;
        }
        else
        {
            playerNumber = 2;
        }

        greenButtonData = redButtonData = blueButtonData = yellowButtonData = false;
        
        timer.SetActive(true);
        timerText.gameObject.SetActive(true);

        if (isServer)
        {
            player.SetActive(true);
        }
        else
        {
            player.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
        // update game state on screen
        buttons[0].GetComponent<StateScript>().ChangeState(greenButtonData);
        buttons[1].GetComponent<StateScript>().ChangeState(redButtonData);
        buttons[2].GetComponent<StateScript>().ChangeState(blueButtonData);
        buttons[3].GetComponent<StateScript>().ChangeState(yellowButtonData);

        //Debug.Log("["+greenButtonData+", "+redButtonData+", "+blueButtonData+", "+yellowButtonData+"]");

        // Timer Mechanic (only works with 2 players)
        if (playerNumber == 1)
        {
            if (greenButtonData == true)
            {
                timer.GetComponent<TimerLogic>().isFalling = true;
                timerText.color = Color.red;
            }
            else
            {
                timer.GetComponent<TimerLogic>().isFalling = false;
                timerText.color = Color.green;
            }
        }
        else if (playerNumber == 2)
        {
            if (redButtonData == true)
            {
                timer.GetComponent<TimerLogic>().isFalling = true;
                timerText.color = Color.red;
            }
            else
            {
                timer.GetComponent<TimerLogic>().isFalling = false;
                timerText.color = Color.green;
            }
        }
    }
    
    public void RequestPress (int button) {
        if (isServer)
        {
            switch (button)
            {
                case 0:
                    greenButtonData = true;
                    redButtonData = blueButtonData = yellowButtonData = false;
                    break;
                case 1:
                    redButtonData = true;
                    greenButtonData = blueButtonData = yellowButtonData = false;
                    break;
                case 2:
                    blueButtonData = true;
                    greenButtonData = redButtonData = yellowButtonData = false;
                    break;
                case 3:
                    yellowButtonData = true;
                    greenButtonData = redButtonData = blueButtonData = false;
                    break;
                default:
                    break;
            }
        }
        else
        {
            //serverRequestPress(button);
        }
    }
}
