using UnityEngine;
using System.Collections;

namespace Sample

{

    public class PrefabTest : MonoBehaviour
    {
        //타일 프리팹
        public GameObject tileprefab;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] 하나 생성
            //Vector3 position = new Vector3(0, 0, 0); //타일 생성 위치 지정
            //Instantiate(tileprefab, position, Quaternion.identity); //타일 생성

            //[2] n(10)*m(10) 생성 
            //GenerateMap2(10,10);

            //[3] 타일을 생성 - x좌표를 0~50사이의 랜덤값, y=0, z좌표를 -50f~0사이의 랜덤값으로 생성
            //for (int i = 0; i < 10; i++)
            //{
            //    GenerateRandomMapTile();
            //}

            //[4] 타일을 10개 찍는다, 타일 하나 생성할때 딜레이를 0.2초 준다.
            //코루틴 (Coroutine) - 0.2초 지연
            StartCoroutine (GenerateRandomMap());
        }

        void GenerateMap(int row, int colum)
        {
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < colum; j++)
                {
                    Vector3 position = new Vector3(i * 5f, 0f, j * -5f); //타일 생성 위치 지정
                    Instantiate(tileprefab, position, Quaternion.identity); //타일 생성
                }
                
            }
        }

        void GenerateMap2(int row, int colum)
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    GameObject go = Instantiate(tileprefab,this.transform); 
                    go.transform.position = new Vector3(i * 5f, 0f, j * -5f);
                }
            }
        }    

        void GenerateRandomMapTile()
        {
            float xPos= Random.Range(0f, 50f);
            float zPos = Random.Range(-50f, 0f);
            Vector3 position = new Vector3(xPos, 0f, zPos); //타일 생성 위치 지정
            Instantiate(tileprefab, position, Quaternion.identity); //타일 생성
        }

        IEnumerator GenerateRandomMap()
        {
            for (int i = 0; i < 10; i++)
            {
            
                Vector3 position = new Vector3(Random.Range(0f, 50f), 0f, Random.Range(-50f, 0f)); //타일 생성 위치 지정
                Instantiate(tileprefab, position, Quaternion.identity); //타일 생성

                //0.2초 지연
                yield return new WaitForSeconds(0.2f);
            }
        }

    }
}

/*
타일을 10*10으로 배치 
 */

