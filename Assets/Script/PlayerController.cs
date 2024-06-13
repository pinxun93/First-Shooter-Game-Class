using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("���a�򥻳]�w")]
    public float maxLifeValue;               // �]�w���a�̰��ͩR��
    public float lifeHpChangeUnit;           // �]�w�C�����ܥͩR�Ȫ����

    [Header("UI�����")]
    public GameManager gameManager;

    float lifeValue;

    void Start()
    {
        lifeValue = maxLifeValue;
    }

    // �I������
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lifeValue -= lifeHpChangeUnit;
            gameManager.UpdateLifeBar(lifeValue / maxLifeValue); // ��s���
        }
    }
}
