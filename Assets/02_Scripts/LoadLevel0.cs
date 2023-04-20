using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel0 : MonoBehaviour
{
    private VRInputActions vrInputActions;

    // Start is called before the first frame update
    void Awake()
    {
        vrInputActions = new VRInputActions();
        vrInputActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (vrInputActions.Default.LeftTrigger.WasPerformedThisFrame())
        {
            SceneManager.LoadScene("Level0");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level0");
    }
}
