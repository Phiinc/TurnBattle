using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�킢���Ǘ�
//Player vs Enemy

public class BattleManager : MonoBehaviour
{
    //Player���擾����
    public UnitManager player;
    //Enemy���擾����
    public UnitManager enemy;

    // Start is called before the first frame update
    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    //Player��Enemy�ɍU��
    //Enemy��Player�ɍU��

    // Update is called once per frame
    void Update()
    {
        
    }
}
