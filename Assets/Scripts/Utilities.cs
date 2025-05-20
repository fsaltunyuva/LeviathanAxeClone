using UnityEngine;

public class Utilities : MonoBehaviour
{
    public void RestartScene()
    {
        // Restart the current scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
