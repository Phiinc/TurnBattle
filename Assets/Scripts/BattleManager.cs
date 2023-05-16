using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        
    }

    //Player��Enemy�ɍU��
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
    //Enemy��Player�ɍU��
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
        Debug.Log("�ΐ�I��");
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
