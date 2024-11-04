using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinSelector : MonoBehaviour
{
    // ���� ��ü ���� ��ư���� ȣ��Ǵ� �Լ�
    public void SelectShip(int index)
    {
        PlayerPrefs.SetInt("SelectedShipIndex", index); // ������ ���� ��ü �ε����� PlayerPrefs�� ����
        Debug.Log("���õ� ���� ��ü �ε���: " + index);
    }

    // ���� ���� ��ư���� ȣ��Ǵ� �Լ�
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Game Scene���� ��ȯ
    }
}
