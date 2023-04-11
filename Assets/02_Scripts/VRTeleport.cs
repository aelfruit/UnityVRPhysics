using UnityEngine;

// from class demo: VR Teleport  notes
public class VRTeleport : MonoBehaviour
{
    public Transform head;
    public Transform hand;

    private VRInputController input;
    public bool teleporting = false;

    private void Awake()
    {
        input = GetComponent<VRInputController>();
    }

    private void Update()
    {
        if (Physics.Raycast(hand.position, hand.forward, out RaycastHit hit))
        {
            if (input.RightTriggerPressed)
            {
                Vector3 directionToHead = transform.position - head.position;
                directionToHead.y = 0;
                transform.position = hit.point + directionToHead;
                teleporting = true;
            }
        }

        Debug.DrawLine(transform.position, head.position, Color.cyan, 0);
        Debug.DrawLine(transform.position, hit.point, Color.yellow, 0);

        if (teleporting)
        {
            Debug.DrawRay(transform.position, Vector3.up * 2, Color.green);
        }
    }
}
