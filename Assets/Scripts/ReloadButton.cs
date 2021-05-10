using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadButton : MonoBehaviour
{
    
    //Reloads the main scene to start a new game
    public void ReloadScene()
    {
        SceneManager.LoadScene("Scene1");
    }
    
}
