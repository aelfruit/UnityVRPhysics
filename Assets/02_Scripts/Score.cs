using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Score : MonoBehaviour
{
    public string tagToCount;
    private int count;
    private int score;
    public TextMeshProUGUI scoreText;

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
        else if (objectsWithTag.Length == count)
        {
            scoreText.text = "You hit nothing. FAIL!";
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "Score:" + score.ToString();
    }

}
