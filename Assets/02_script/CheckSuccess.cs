using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckSuccess : MonoBehaviour
{
    //public TextMeshProUGUI succesText;
    private float timer = 0f;


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Wait for 10 seconds before checking for the tag
        if (timer > 10f)
        {
            // Check if there are any objects with the "MonsterBody" tag
            GameObject[] monsters = GameObject.FindGameObjectsWithTag("MonsterBody");
            if (monsters.Length == 0)
            {
                // If there are no objects with the tag, display the success text

                //successText.text = "Success";
                Debug.Log("Success");
            }
        }
    }
}
