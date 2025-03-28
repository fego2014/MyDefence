using UnityEngine;
using System.Collections;
using TMPro;

namespace MyDefence
{
    //Enemy 스폰/웨이브를 관리하는 스크립트

    public class WaveMnager : MonoBehaviour
    {
        //적 프리팹
        public GameObject enemyPrefab;
        //적 스폰위치
        public Transform startPoint;
        //티아머
        public float waveTimer = 5f;
        private float countdown = 0f;

        //웨이브 카운트
        private int waveCount = 0;

        //UI countdown Text
        public TextMeshProUGUI countdownText;

        void Start()
        {
            //필드 초기화
            countdown = 0f;
            waveCount = 0;
        }


        void Update()
        {
            //타이머 구현
            countdown += Time.deltaTime;
            if(countdown >= waveTimer)
            {
                //타이머 기능
                StartCoroutine(SpawnWave());
                

                //타이머 초기화
                countdown = 0f;
            }

            //UI
            countdownText.text = Mathf.Round(countdown).ToString();
        }

        //웨이브
        IEnumerator SpawnWave()
        {
            waveCount++;

            for (int i = 0; i < waveCount; i++)
            {
                SpawnEnemy();

                //일정시간 지연
                yield return new WaitForSeconds(0.3f);
            }
        }

        void SpawnEnemy()
        {
            //시작 지점에 enemy 한마리 스폰
            Instantiate(enemyPrefab, startPoint.position, Quaternion.identity);
        }

        
    }
}
