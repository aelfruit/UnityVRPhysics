using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    public string tagToCount;
    private int count;
    private int score;
    public TextMeshProUGUI scoreText;
    private float timer = 0f;
    public TextMeshProUGUI succesText;

    // Start is called before the first frame update
    private void Start()
    {
        tagToCount = "MonsterBody";
        //count existing objects with the tag
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToCount);
        count = objectsWithTag.Length;
        Debug.Log($"Currently there are" + objectsWithTag.Length + "to throw at and destroy");
        score = 0;
        SetScoreText();
    }

    void Update()
    {
        timer += Time.deltaTime;

        // Wait for 10 seconds before checking for the tag
        if (timer > 2f)
        {
            // Check if there are any objects with the "MonsterBody" tag
            GameObject[] monsters = GameObject.FindGameObjectsWithTag("MonsterBody");
            if (monsters.Length == 0)
            {
                // If there are no objects with the tag, display the success text

                succesText.text = "Success";
                //successText.text = "Success";
                Debug.Log("Success");
            }
        }
    }
    private void FixedUpdate()
    {
        //check objects with tag to subtract and get score from when destroyed
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToCount);
        if (objectsWithTag.Length < count)
        {
            // calculate number of destroyed objects and add to score
            int destroyedCount = count - objectsWithTag.Length;
            score += destroyedCount;
            count = objectsWithTag.Length;
            SetScoreText();
        }
        else if (objectsWithTag.Length > count)
        {
            // calculate new number of destroyed objects and add to score
            int newCount = objectsWithTag.Length - count;
            score += newCount;
            count = objectsWithTag.Length;
            SetScoreText();

            //score = count - objectsWithTag.Length;
            //score = count - score;            
        }
        
        if (score ==0)
        {
            scoreText.text = "You hit nothing..(Fail State)";
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();
    }

}
