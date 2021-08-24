using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///  � ���� ������� ����� ����������� ��� �������� � ������� ����.
/// </summary>
public class MenuSwich : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadQuickGame()
    {
        SceneManager.LoadScene(1); // �������� ������� ����
    }

   public void QuittingTheGame()
    {
        Application.Quit(); // ����� �� ����
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
