using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] playerShips; // 비행 객체 프리팹 배열

    void Start()
    {
        SpawnPlayerShip();
    }

    private void SpawnPlayerShip()
    {
        // PlayerController로부터 선택된 비행 객체 인덱스를 가져옴
        int selectedShipIndex = PlayerController.instance.GetSelectedShipIndex();

        // 선택된 비행 객체를 현재 위치에 소환
        if (selectedShipIndex >= 0 && selectedShipIndex < playerShips.Length)
        {
            Instantiate(playerShips[selectedShipIndex], transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("잘못된 비행 객체 인덱스입니다.");
        }
    }
}
