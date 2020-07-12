using UnityEngine;
using UnityEngine.SceneManagement;
  
public class GoToScene : MonoBehaviour
{
    public void GoToLevel(string level="1_Stars")
    {
        SceneManager.LoadScene(level);
    }
}
