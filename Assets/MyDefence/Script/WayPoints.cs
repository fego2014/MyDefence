using Unity.VisualScripting;
using UnityEngine;

namespace MyDefence
{

    public class WayPoints : MonoBehaviour
    {
        //필드
        public static Transform[] wayPoints;

        
        private void Awake()
        {
            //필드 초기화
            wayPoints=new Transform[this.transform.childCount];
            for(int i = 0; i < wayPoints.Length; i++)
            {
                wayPoints[i] = this.transform.GetChild(i);

                Debug.Log($"{wayPoints[i].position}");
            }
        }

        
    }
}
