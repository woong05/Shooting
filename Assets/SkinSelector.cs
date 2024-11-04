using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinSelector : MonoBehaviour
{
    // 비행 객체 선택 버튼에서 호출되는 함수
    public void SelectShip(int index)
    {
        PlayerPrefs.SetInt("SelectedShipIndex", index); // 선택한 비행 객체 인덱스를 PlayerPrefs에 저장
        Debug.Log("선택된 비행 객체 인덱스: " + index);
    }

    // 게임 시작 버튼에서 호출되는 함수
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Game Scene으로 전환
    }
}
