//마우스 클릭하면 밤송이가 과녁으로 날아가는 동작 제어 스크립트


using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //디바이스 성능에 따른 실행결과 차이 제거
        Application.targetFrameRate = 60;

        /*
         * 밤송이가 화면 안쪽으로 날아가도록 Z축 방향의 벡터를 매개변수로 전달하고 f_TargetShoot 메서드를 호출
         * Y축 방향으로 힘을 200 가하는 이유는 밤송이가 과녁에 닿기 전에 중력의 영향을 받아
         * 지면으로 낙하하는 것을 막기 위함
         * Start 메서드를 호출하는 시작과 동시에 밤송이가 과녁으로 날아감
         */
        f_TargetShoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //매개변수 방향으로 밤송이에게 힘을 가하는 메소드
    public void f_TargetShoot(Vector3 argDir)
    {
        //매개변수로 전달된 Vector 값으로 힘을 가함
        GetComponent<Rigidbody>().AddForce(argDir);
    }

    //Physics를 사용하므로 과녁과 밤송이가 충돌하면 OnCollisionEnter 메서드가 호출되어 실행됨
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;

        GetComponent<ParticleSystem>().Play();
    }
}
