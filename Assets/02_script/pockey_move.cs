using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pockey_move : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 5f;

    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = startPosition + new Vector3(Mathf.Sin(Time.time * speed) * distance, 0f, 0f);

        transform.position = newPosition;

    }
}
