using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour {
    public Swipe swipeController;
    public float transitionSpeed;

    private int currentPanel, nextPanel;
    private bool isAnimating;
    private Vector3 direction;

    private float distanceRemaining;
    private float distanceBetweenPanels;

	// Use this for initialization
	void Start () {
        currentPanel = 3;
        isAnimating = false;
        distanceBetweenPanels = GetComponent<RectTransform>().rect.width;
	}
    
	// Update is called once per frame
	void Update () {
        if (!isAnimating)
        {
            if (swipeController.SwipeRight && currentPanel > 1)
            {
                isAnimating = true;
                nextPanel = currentPanel - 1;
                direction = Vector3.right;
                distanceRemaining = distanceBetweenPanels;
            }
            else if (swipeController.SwipeLeft && currentPanel < 5)
            {
                isAnimating = true;
                nextPanel = currentPanel + 1;
                direction = Vector3.left;
                distanceRemaining = distanceBetweenPanels;
            }
        }
		else
        { 
            if (transitionSpeed >= distanceRemaining)
            {
                GetComponent<RectTransform>().anchoredPosition += distanceRemaining * new Vector2(direction.x, direction.y);
                distanceRemaining = 0.0f;

                currentPanel = nextPanel;
                isAnimating = false;
            }
            else
            {
                GetComponent<RectTransform>().anchoredPosition += transitionSpeed * new Vector2(direction.x, direction.y);
                distanceRemaining -= transitionSpeed;
            }
            
        }
	}
}
