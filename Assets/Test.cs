using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Boss
{
    private int hp = 100;    // �̗�
    private int power = 25; // �U����
    private int mp = 53;     //���@


    // �U���p�̊֐�
    public void Attack(int �v���X)
    {
        Debug.Log(this.power +�@�v���X +"�̃_���[�W��^����");
    }

    // (���@�j�U���p�̊֐�
    public void Magic()
    {
        this.mp -= 5;
        Debug.Log( "���@�U���������I�c��MP�� " + this.mp + "�B");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
        Debug.Log(this.hp+"�i�ғ��m�F�p�j");
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack(0);
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);

        //**********���W�ۑ�FBoss�N���X�ɁA�ϐ�mp��Magic�֐����쐬����Start�֐�����Ăяo����***********
        // �i���@�j�U���p�̊֐����Ăяo��
        for (int i=1;i<=10; i++)
        {
            lastboss.Magic();
            if(i>=10)
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }

        //���K�F�V����Boss�N���X��midboss�ϐ������AAttack�֐���Defence�֐����Ăяo���Ă݂܂��傤�B
        Boss fainalboss = new Boss();
        fainalboss.Attack(10);
        fainalboss.Defence(5);

        //**********�ۑ�F�z���錾���ďo�͂��悤*************
        int[] array = { 5, 10, 15, 20, 30 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}