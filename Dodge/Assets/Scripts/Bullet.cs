using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {   // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;
        //bulletRigidbody.velocity = transform.forward * speed;
        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3f);
        
    }
    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    void OnTriggerEnter(Collider other)
    {   // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if(other.tag == "Player")
        {   // ���� ���� ������Ʈ�� PlayerController ������Ʈ ��������
            PlayerController PlayerController = other.GetComponent<PlayerController>();

            // �������κ��� PlayerController ������Ʈ�� �������� �� ����������
            if(PlayerController != null)
            {   // ���� PlayerController ������Ʈ�� Die() �޼��� ����
                PlayerController.Die();
                //PlayerController.Die()
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
