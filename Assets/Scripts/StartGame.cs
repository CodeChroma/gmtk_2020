using UnityEngine;
using UnityEngine.SceneManagement;
  
public class StartGame : MonoBehaviour
{
    public void GoToLevel(string level="1_Stars")
    {
        SceneManager.LoadScene(level);
    }
}
