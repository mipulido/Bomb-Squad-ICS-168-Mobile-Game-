using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        // standalone inputs
        if (Input.touches.Length > 0)
        {
            SceneManager.LoadScene("GameScene");
        }
        
        // mouse inputs
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
