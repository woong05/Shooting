using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] playerShips; // ���� ��ü ������ �迭

    void Start()
    {
        SpawnPlayerShip();
    }

    private void SpawnPlayerShip()
    {
        // PlayerController�κ��� ���õ� ���� ��ü �ε����� ������
        int selectedShipIndex = PlayerController.instance.GetSelectedShipIndex();

        // ���õ� ���� ��ü�� ���� ��ġ�� ��ȯ
        if (selectedShipIndex >= 0 && selectedShipIndex < playerShips.Length)
        {
            Instantiate(playerShips[selectedShipIndex], transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("�߸��� ���� ��ü �ε����Դϴ�.");
        }
    }
}
