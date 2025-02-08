using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class StartScene : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("GameScene");
    }

}
