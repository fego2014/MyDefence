using UnityEngine;
namespace Sample
{

    public class MOveTest : MonoBehaviour
    {
        //필드
        //이동속도
        private float speed = 5f; //5m/s, 초속 5미터

        //이동 목표 지정
        Vector3 targetPosition = new Vector3(7f, 1f, 8f);

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // this.transform : MoveTest 스크립트가 붙어있는 게임 오브젝트의 Transform
            //this.transform.position=new Vector3(7f, 1f, 8f);
            //this.transform.position = targetPosition;
            //Debug.Log(this.transform.position);
        }

        // Update is called once per frame
        void Update()
        {
            //플레이어의 위치를 앞으로 이동하라
            //this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f);
            //this.transform.position += Vector3.forward;

            //플레이어의 위치를 뒤로 이동하라
            //this.transform.position = this.transform.position + new Vector3(0f, 0f, -1f);
            //this.transform.position += Vector3.back;

            //플레이어의 위치를 좌로 이동하라
            //this.transform.position = this.transform.position + new Vector3(-1f, 0f, 0f);
            //this.transform.position += Vector3.left;

            //플레이어의 위치를 우로 이동하라
            //this.transform.position = this.transform.position + new Vector3(1f, 0f, 0f);
            //this.transform.position += Vector3.right;

            //플레이어의 위치를 위로 이동하라
            //this.transform.position = this.transform.position + new Vector3(0f, 1f, 0f);
            //this.transform.position += Vector3.up;

            //플레이어의 위치를 아래로 이동하라
            //this.transform.position = this.transform.position + new Vector3(0f, -1f, 0f);
            //this.transform.position += Vector3.down;

            //속도
            //앞 방향으로 1초에 1unit 만큼 이동하라
            //this.transform.position += Vector3.forward * Time.deltaTime;
            //앞 방향으로 1초에 5unit 만큼 이동하라
            //this.transform.position += Vector3.forward * Time.deltaTime * speed;

            //Translate : 이동함수
            //방향 : 앞방향
            //Time.deltaTime : 이전 프레임부터 현재 프레임까지 걸린 시간
            //speed : 초당 5m
            //this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

            //이동방향 구하기  (목표위치 - 현재위치), (목표위치 - 현재위치 ).normalized
            //dir.magnitude : 벡터의 크기, 길이, 방향과 크기를 구하는 것
            //dir.nomalized : 길이가 1인 벡터, 정규화된 벡터, 단위벡터, 방향만 구하는 것
            //Vector3 dir = targetPosition - this.transform.position;
            //transform.Translate(dir.normalized * Time.deltaTime * speed);

            //Space.World : 월드좌표계 기준으로 이동
            //transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World);
            //Space.Self : 로컬좌표계 기준으로 이동
            transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
        }
    }
}

/*
1. 앞, 뒤, 좌, 우로 이동하기
2. 5의 속도로 이동하기
3. 목표지점(7,1,8) 으로 이동하기
4. 목표지점 도착 판정

1 unit = 1m

n 프레임 : 초당 n번 실행하기(보여주기)
20프레임 : 1초에 20번 실행하기 -> 1프레임당 0.05초
FPS(Frame Per Second) : 초당 프레임 수

unity
Time.deltaTime : 이전 프레임부터 현재 프레임까지 걸린 시간 (사용자의 컴퓨터 성능과 상관없이 일정한 속도로 이동)
//this.transform.position += Vector3.forward * Time.deltaTime;
Time.deltaTime 을 곱하면 1초에 1m만큼 이동

초당 20만큼 이동
speed = 20;
this.transform.position += Vector3.forward * Time.deltaTime * speed;
 */

