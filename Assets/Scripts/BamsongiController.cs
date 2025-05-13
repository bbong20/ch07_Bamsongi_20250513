//���콺 Ŭ���ϸ� ����̰� �������� ���ư��� ���� ���� ��ũ��Ʈ


using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //����̽� ���ɿ� ���� ������ ���� ����
        Application.targetFrameRate = 60;

        /*
         * ����̰� ȭ�� �������� ���ư����� Z�� ������ ���͸� �Ű������� �����ϰ� f_TargetShoot �޼��带 ȣ��
         * Y�� �������� ���� 200 ���ϴ� ������ ����̰� ���ῡ ��� ���� �߷��� ������ �޾�
         * �������� �����ϴ� ���� ���� ����
         * Start �޼��带 ȣ���ϴ� ���۰� ���ÿ� ����̰� �������� ���ư�
         */
        f_TargetShoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�Ű����� �������� ����̿��� ���� ���ϴ� �޼ҵ�
    public void f_TargetShoot(Vector3 argDir)
    {
        //�Ű������� ���޵� Vector ������ ���� ����
        GetComponent<Rigidbody>().AddForce(argDir);
    }

    //Physics�� ����ϹǷ� ����� ����̰� �浹�ϸ� OnCollisionEnter �޼��尡 ȣ��Ǿ� �����
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;

        GetComponent<ParticleSystem>().Play();
    }
}
