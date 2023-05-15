using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//í‚¢‚ğŠÇ—
//Player vs Enemy

public class BattleManager : MonoBehaviour
{
    //Player‚ğæ“¾‚·‚é
    public UnitManager player;
    //Enemy‚ğæ“¾‚·‚é
    public UnitManager enemy;

    // Start is called before the first frame update
    void Start()
    {
        player.Attack(enemy);
        enemy.Attack(player);
    }

    //Player‚ªEnemy‚ÉUŒ‚
    //Enemy‚ªPlayer‚ÉUŒ‚

    // Update is called once per frame
    void Update()
    {
        
    }
}
