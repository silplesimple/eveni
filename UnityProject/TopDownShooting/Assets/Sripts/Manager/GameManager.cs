using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    public Transform player { get; private set; }    
    [SerializeField] private string playerTag = "Player";
    private HealthSystem playerHealthSystem;

    [SerializeField] private TextMeshProUGUI waveText;
    [SerializeField] private Slider hpGaugeSlider;
    [SerializeField] private GameObject gameOverUI;
    CameraManager cameraManager;

    //Coroutine
    [SerializeField] private int currentWaveIndex = 0;
    private int currentSpawnCount = 0;
    private int waveSpawnCount = 0;
    private int waveSpawnPosCount = 0;

    public float spwanInterval = .5f;
    public List<GameObject> enemyPrefaps = new List<GameObject>();

    [SerializeField] private Transform spawnPositionRoot;
    private List<Transform> spawnPositions = new List<Transform>();

    private void Awake()
    {      
        DontDestroyOnLoad(gameObject);
        cameraManager = CameraManager.Instance;
        player = GameObject.FindGameObjectWithTag(playerTag).transform;
        if (player != null)
        {
            playerHealthSystem = player.GetComponent<HealthSystem>();
            playerHealthSystem.OnDamage += UpdateHealthUI;
            playerHealthSystem.OnHeal += UpdateHealthUI;
            playerHealthSystem.OnDeath += GameOver;
        }
        gameOverUI.SetActive(false);
        //Coroutine

        //for(int i=0;i<spawnPositionRoot.childCount;i++)
        //{
        //    spawnPositions.Add(spawnPositionRoot.GetChild(i));
        //}
    }

    private void UpdateHealthUI()
    {
        hpGaugeSlider.value = playerHealthSystem.CurrentHealth / playerHealthSystem.MaxHealth;
    }

    private void GameOver()
    {
        gameOverUI?.SetActive(true);
    }

    private void UpdateWaveUI()
    {
        //waveText.text=   
    }

    public void RestartGame()
    {        
        Instance.DestroySingleton();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
