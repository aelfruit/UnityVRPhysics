using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
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
        if (vrInputActions.Default.Menu.WasPerformedThisFrame())        
        {
            SceneManager.LoadScene("MenuLevel");
        }
    }
}

