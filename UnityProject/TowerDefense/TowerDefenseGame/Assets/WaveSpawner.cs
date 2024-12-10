using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;
    public List<Transform> enemys;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public TextMeshProUGUI WaveCountDownText;

    private int waveIndex = 0;

    private void Update()
    {
        NextWave();
    }

    //다음 웨이브
    private void NextWave()
    {        
        if(countdown<=0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        //Math.Floor <- 내림으로 처리하여 정수로 반환되는것 처럼 보임
        WaveCountDownText.text = Mathf.Round(countdown).ToString();
    }
    IEnumerator SpawnWave()
    {       
        waveIndex++;
        Debug.Log("다음웨이브" + waveIndex);


        for(int i=0;i<waveIndex;i++)
        {
            SpawnEnemy();
            //이건 함수 발동 시간을 0.5초 씩 늦추기 위해 사용
            yield return new WaitForSeconds(0.5f);
            
        }

    }

    private void SpawnEnemy()
    {
        enemys.Add(Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation));        
    }
}
