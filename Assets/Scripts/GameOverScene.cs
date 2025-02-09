using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
    public void RestartGame() {
        SceneManager.LoadScene(1);
    }
}
