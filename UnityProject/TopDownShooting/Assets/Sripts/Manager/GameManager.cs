using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    [SerializeField] private CharacterStats defaultStats;
    [SerializeField] private CharacterStats rangedStats;

    //Coroutine
    [SerializeField] private int currentWaveIndex = 0;
    private int currentSpawnCount = 0;
    private int waveSpawnCount = 0;
    private int waveSpawnPosCount = 0;

    public float spawnInterval = .5f;
    public List<GameObject> enemyPrefaps = new List<GameObject>();

    [SerializeField] private Transform spawnPositionRoot;
    private List<Transform> spawnPositions = new List<Transform>();
    [SerializeField] private List<GameObject> rewards;

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

        for (int i = 0; i < spawnPositionRoot.childCount; i++)
        {
            spawnPositions.Add(spawnPositionRoot.GetChild(i));
            Debug.Log(spawnPositions.Count);
        }        
    }

    private void Start()
    {
        UpgradeStatInit();       
        StartCoroutine("StartNextWave");
    }

    IEnumerator StartNextWave()
    {
        
        while(true)
        {
            if(currentSpawnCount==0)
            {
                UpdateWaveUI();
                yield return new WaitForSeconds(2f);

                if(currentWaveIndex%20==0)
                {
                    RandomUpgrade();
                }

                if(currentWaveIndex % 10==0)
                {
                    waveSpawnPosCount = waveSpawnPosCount + 1 > spawnPositions.Count?
                        waveSpawnPosCount : waveSpawnPosCount + 1;
                    waveSpawnCount = 0;
                }

                if(currentWaveIndex % 5==0)
                {
                    CreateReward();
                }

                if(currentWaveIndex %3 ==0)
                {
                    waveSpawnCount += 1;
                    
                }

                for(int i=0;i<waveSpawnPosCount;i++)
                {
                    Debug.Log("이거 실행중?");
                    int posIdx = Random.Range(0, spawnPositions.Count);
                    for(int j=0;j<waveSpawnCount;j++)
                    {
                        Debug.Log("적 생성 완료");
                        int prefabIdx = Random.Range(0, enemyPrefaps.Count);
                        GameObject enemy = Instantiate(enemyPrefaps[prefabIdx],
                        spawnPositions[posIdx].position, Quaternion.identity);
                        enemy.GetComponent<HealthSystem>().OnDeath += OnEnemyDeath;
                        enemy.GetComponent<CharacterStatsHandler>().AddStatModifier(defaultStats);
                        enemy.GetComponent<CharacterStatsHandler>().AddStatModifier(rangedStats);
                        currentSpawnCount++;
                        yield return new WaitForSeconds(spawnInterval);
                    }
                }
                currentWaveIndex++;
                Debug.Log("웨이브 인덱스 개수");
            }

            yield return null;
        }
    }

    private void RandomUpgrade()
    {
        switch(Random.Range(0,6))
        {
            case 0:
                defaultStats.maxHealth += 2;
                break;
            case 1:
                defaultStats.attackSO.power += 1;
                break;
            case 2:
                defaultStats.speed += 0.1f;
                break;
            case 3:
                defaultStats.attackSO.isOnKnockback = true;
                defaultStats.attackSO.knockbackPower += 1;
                defaultStats.attackSO.knockbackTime = 0.1f;
                break;
            case 4:
                defaultStats.attackSO.delay -= 0.05f;
                break;
            case 5:
                RangedAttackData rangedAttackData = rangedStats.attackSO as RangedAttackData;
                rangedAttackData.numberofProjectPerShot += 1;
                break;

            default:
                break;
        }
    }
    private void UpgradeStatInit()
    {
        defaultStats.statsChangeType = StatsChangeType.Add;
        defaultStats.attackSO = Instantiate(defaultStats.attackSO);

        rangedStats.statsChangeType= StatsChangeType.Add;
        rangedStats.attackSO=Instantiate(rangedStats.attackSO); 
    }
    private void CreateReward()
    {
        if(rewards==null&&spawnPositions==null)
        {
            Debug.Log("오브젝트가 없습니다");
            return;
        }
        int idx = Random.Range(0, rewards.Count);
        int posIdx = Random.Range(0, spawnPositions.Count);

        GameObject obj = rewards[idx];
        Instantiate(obj, spawnPositions[posIdx].position, Quaternion.identity);
    }
    private void OnEnemyDeath()
    {
        currentSpawnCount--;    
    }

    private void GameOver()
    {
        gameOverUI.SetActive(true);
        StopAllCoroutines();
    }
    private void UpdateHealthUI()
    {
        hpGaugeSlider.value = playerHealthSystem.CurrentHealth / playerHealthSystem.MaxHealth;
    }

    
    private void UpdateWaveUI()
    {
        Debug.Log("UI 생성 완료");
        waveText.text = (currentWaveIndex+1).ToString();
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
