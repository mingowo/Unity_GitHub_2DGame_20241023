using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour {
    public void LoadScene(string sceneName) {
        //場景管理器 的 載入場景(場景名稱)
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame() {
        //應用程式的離開();
        Application.Quit();
    }
}