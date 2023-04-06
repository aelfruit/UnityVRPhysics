using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangEffect : MonoBehaviour
{
    public float throwSpeed = 70f; // speed of the boomerang
    public float rotateSpeed = 800f; // speed at which the boomerang rotates
    public float returnSpeed = 20f; // speed at which the boomerang returns to the player's hand
    public float travelDistance = 50f; // distance of the boomerang should travel before returning

    private bool isThrown = false; // flag to track whether the boomerang has been thrown
    private bool isReturning = false; // flag to track whether the boomerang is returning
    private Vector3 throwDirection; // direction in which the boomerang was thrown
    private Quaternion throwRotation; // rotation of the player's arm when the boomerang was thrown
    private Vector3 targetPosition; // position to which the boomerang should travel before returning


    // Update is called once per frame
    void Update()
    {
        // check if the player has pressed the "Space" key and the boomerang hasn't been thrown yet.
        // -----Player can throw the weapon-----
        // get weapon's rotation and target position.
        if (Input.GetKeyDown(KeyCode.Space) && !isThrown)
        {
            isThrown = true;
            throwDirection = transform.parent.forward;
            throwRotation = transform.parent.rotation;
            targetPosition = transform.parent.position + throwDirection * travelDistance;
            Debug.Log(targetPosition);
        }

        // check if isThrown is true.
        // -----* Weapon starts moving and rotating through the air towards its target position
        if (isThrown)
        {
            transform.Rotate(Vector3.right, rotateSpeed * Time.deltaTime);// rotate the boomerang

            if (!isReturning)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, throwSpeed * Time.deltaTime); // move the boomerang towards its target
                //transform.position = Vector3.Lerp(transform.position, targetPosition, throwSpeed * Time.deltaTime); // move the boomerang towards its target

                // check if the weapon has reached its target
                // -----* Weapon starts returning it to the player's hand
                if (transform.position == targetPosition)
                {
                    isReturning = true;
                    targetPosition = transform.parent.position; // set weapon target position to player's hand
                    Debug.Log(targetPosition);
                }
            }
            // if the boomerang has returned to the player's hand, reset its state
            else if (isReturning)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, returnSpeed * Time.deltaTime); // move the boomerang towards player's hand

                if (transform.position == targetPosition)
                {
                    transform.rotation = throwRotation;
                    isThrown = false;
                    isReturning = false;
                }
            }
        }
    }

    // checks if the object that the boomerang has collided with has a "tag" that is set to "MonsterBody"
    // -----Destroy the monster when hit by the boomerang-----
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter Collid");
        if (isThrown && other.CompareTag("MonsterBody"))
        {
            Destroy(other.gameObject);
        }
    }
}