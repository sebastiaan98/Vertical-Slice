﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonSelect : SceneChanger {

    public GameObject image;
    public GameObject omage;


        void Update() {


        if (Input.GetKeyDown(KeyCode.Return))
        {
			SceneManager.LoadScene(1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            omage.SetActive(false);
            image.SetActive(true);
            transform.position = new Vector3(130, 270, 0);

        }
        if  (Input.GetKeyDown(KeyCode.D))
        {
            image.SetActive(false);
            omage.SetActive(true);
            transform.position = new Vector3(400, 270, 0);
            
        }
    
    }
    
}
