using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�L�����N�^�[���Ǘ�.
public class UnitManager : MonoBehaviour
{
    //Status
    public int hp;
    public int at;

    //�U���֐�
    public void Attack(UnitManager target)
    {
        target.Damage(at);
    }

    //�_���[�W�֐�
    void Damage(int damage)
    {
        hp -= damage;
        Debug.Log(name+"��"+damage+"�_���[�W���󂯂�");
    }
}
