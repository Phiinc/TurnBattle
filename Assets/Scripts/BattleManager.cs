using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        
    }

    //Player‚ªEnemy‚ÉUŒ‚
    public void OnAttackButton()
    {
        player.Attack(enemy);
        if (enemy.hp > 0 ) 
        {
            EnemyTurn();
        }
        else
        {
            BattleEnd();
        }
        
    }
    //Enemy‚ªPlayer‚ÉUŒ‚
    void EnemyTurn()
    {
        enemy.Attack(player);
        if (player.hp > 0)
        {
            BattleEnd();
        }
    }

    void BattleEnd()
    {
        Debug.Log("‘ÎíI—¹");
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
