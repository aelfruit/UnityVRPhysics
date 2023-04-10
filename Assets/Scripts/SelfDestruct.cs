using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    //destroy when hit
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    //destroy other game object
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(collision.gameObject);
    //}
}
