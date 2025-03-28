using UnityEngine;
namespace Sample
{

    public class ObjectTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.transform
            //= ObjectTest 가 붙어있는 게임오브젝트의 transform의 인스턴스 
            Debug.Log(this.transform);
            //this.gameObject
            //= ObjectTest 가 붙어있는 게임오브젝트의 gameObject의 인스턴스 
            Debug.Log(this.gameObject);

            //this.gameObject.transform == this.transform
            //= ObjectTest 가 붙어있는 게임오브젝트의 transform의 인스턴스
            //this.transform == this.gameObject.transform
            //= ObjectTest 가 붙어있는 게임오브젝트의 transform의 인스턴스
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}


