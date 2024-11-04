using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Singleton 인스턴스
    public static PlayerController instance;

    // 플레이어 속성과 체력
    private float speed = 5.0f;
    private int hp = 100;

    // 선택된 비행 객체 인덱스를 저장할 변수
    public int selectedShipIndex;

    void Awake()
    {
        // Singleton 패턴 설정
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시에도 객체 유지
        }
        else
        {
            Destroy(gameObject); // 이미 인스턴스가 있다면 새로운 객체를 제거
        }
    }

    void Start()
    {
        // PlayerPrefs에서 선택된 비행 객체 인덱스를 불러옴
        selectedShipIndex = PlayerPrefs.GetInt("SelectedShipIndex", 0); // 기본값 0
    }

    // 선택된 비행 객체 인덱스를 반환하는 함수
    public int GetSelectedShipIndex()
    {
        return selectedShipIndex;
    }

    // 플레이어 속도 가져오기
    public float GetSpeed()
    {
        return speed;
    }

    // 플레이어 체력 가져오기
    public int GetHP()
    {
        return hp;
    }

    // 플레이어 체력 설정하기
    public void SetHP(int newHP)
    {
        hp = newHP;
    }

    // 데미지를 입을 때 호출되는 함수
    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    // 플레이어가 죽을 때 호출되는 함수
    public void Die()
    {
        Time.timeScale = 0f; // 게임을 멈춤
    }

    void Update()
    {
        // R 키로 게임을 재시작
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
