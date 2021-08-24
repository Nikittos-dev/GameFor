using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///  ¬ этом скрипте будут описыватьс€ все переходы в главном меню.
/// </summary>
public class MenuSwich : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadQuickGame()
    {
        SceneManager.LoadScene(1); // загрузка быстрой игры
    }

   public void QuittingTheGame()
    {
        Application.Quit(); // выход из игры
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
