using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Singleton �ν��Ͻ�
    public static PlayerController instance;

    // �÷��̾� �Ӽ��� ü��
    private float speed = 5.0f;
    private int hp = 100;

    // ���õ� ���� ��ü �ε����� ������ ����
    public int selectedShipIndex;

    void Awake()
    {
        // Singleton ���� ����
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // �� ��ȯ �ÿ��� ��ü ����
        }
        else
        {
            Destroy(gameObject); // �̹� �ν��Ͻ��� �ִٸ� ���ο� ��ü�� ����
        }
    }

    void Start()
    {
        // PlayerPrefs���� ���õ� ���� ��ü �ε����� �ҷ���
        selectedShipIndex = PlayerPrefs.GetInt("SelectedShipIndex", 0); // �⺻�� 0
    }

    // ���õ� ���� ��ü �ε����� ��ȯ�ϴ� �Լ�
    public int GetSelectedShipIndex()
    {
        return selectedShipIndex;
    }

    // �÷��̾� �ӵ� ��������
    public float GetSpeed()
    {
        return speed;
    }

    // �÷��̾� ü�� ��������
    public int GetHP()
    {
        return hp;
    }

    // �÷��̾� ü�� �����ϱ�
    public void SetHP(int newHP)
    {
        hp = newHP;
    }

    // �������� ���� �� ȣ��Ǵ� �Լ�
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    // �÷��̾ ���� �� ȣ��Ǵ� �Լ�
    public void Die()
    {
        Time.timeScale = 0f; // ������ ����
    }

    void Update()
    {
        // R Ű�� ������ �����
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
