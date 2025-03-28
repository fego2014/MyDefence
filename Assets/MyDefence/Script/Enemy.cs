using UnityEngine;

namespace MyDefence
{

    public class Enemy : MonoBehaviour
    {
        //필드
        
        public float speed = 5f;

        //private Vector3 targetPosition;
        private Transform target;
        private int wayPointIndex = 0;
       
        void Start()
        {
            //targetPosition = new Vector3(-2, 1, 0);
            wayPointIndex = 0;
            target = WayPoints.wayPoints[wayPointIndex];
        }

        void Update()
        {
            //이동 구현
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);

            //targetPosition 목표지점 도착 판정
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance <= 0.1f)
            {
                Debug.Log("도착");
                //다음 타겟 세팅
                GetNextTarget();
               
            }
        }

        //다음 타켓포지션 얻어오기
        void GetNextTarget()
        {
            if(wayPointIndex == WayPoints.wayPoints.Length-1)
            {
                Debug.Log("종점 도착");

                Destroy(this.gameObject);
                return;
            }

            wayPointIndex++;
                        
            target = WayPoints.wayPoints[wayPointIndex];
        }
    }

}
