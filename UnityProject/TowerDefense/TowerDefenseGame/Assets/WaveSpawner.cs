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

    //���� ���̺�
    private void NextWave()
    {        
        if(countdown<=0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        //Math.Floor <- �������� ó���Ͽ� ������ ��ȯ�Ǵ°� ó�� ����
        WaveCountDownText.text = Mathf.Round(countdown).ToString();
    }
    IEnumerator SpawnWave()
    {       
        waveIndex++;
        Debug.Log("�������̺�" + waveIndex);


        for(int i=0;i<waveIndex;i++)
        {
            SpawnEnemy();
            //�̰� �Լ� �ߵ� �ð��� 0.5�� �� ���߱� ���� ���
            yield return new WaitForSeconds(0.5f);
            
        }

    }

    private void SpawnEnemy()
    {
        enemys.Add(Instantiate(enemyPrefab,spawnPoint.position,spawnPoint.rotation));        
    }
}
