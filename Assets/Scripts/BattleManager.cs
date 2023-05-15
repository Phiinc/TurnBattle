using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//戦いを管理
//Player vs Enemy

public class BattleManager : MonoBehaviour
{
    //Playerを取得する
    public UnitManager player;
    //Enemyを取得する
    public UnitManager enemy;

    // Start is called before the first frame update
    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    //PlayerがEnemyに攻撃
    //EnemyがPlayerに攻撃

    // Update is called once per frame
    void Update()
    {
        
    }
}
