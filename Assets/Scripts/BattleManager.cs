using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Fighter player;
    public Fighter enemy;

    public TMP_Text playerHPText;
    public TMP_Text enemyHPText;

    public void PlayerAttack()
    {
        // Player attacks
        enemy.hp -= player.attack;

        UpdateHPText();

        Debug.Log(player.fighterName + "You attacked!");
        Debug.Log("Enemy HP: " + enemy.hp);

        // Check if enemy lost
        if (enemy.hp <= 0)
        {
            Debug.Log("You Win!");
            return;
        }

        // Enemy attacks
        player.hp -= enemy.attack;

        UpdateHPText();

        Debug.Log(enemy.fighterName + "Enemy attacked!");
        Debug.Log("Player HP: " + player.hp);

        // Check if player lost
        if (player.hp <= 0)
        {
            Debug.Log("You Lose!");
        }
    }

       public void UpdateHPText()
        {
            playerHPText.text =
                player.fighterName + "Your HP: " + player.hp;

            enemyHPText.text =
                enemy.fighterName + "Enemy HP: " + enemy.hp;
        }

        void Start()
        {
            UpdateHPText();
        }

        public void Tackle()
    {
        UseMove("Tackle", 10);
    }

    public void Scratch()
    {
        UseMove("Scratch", 15);
    }

    public void Bite()
    {
        UseMove("Bite", 25);
    }

    public void Heal()
    {
        player.hp += 25;

        Debug.Log(player.fighterName + "You healed!");

        UpdateHPText();

        EnemyTurn();
    }

    void UseMove(string moveName, int damage)
    {
        enemy.hp -= damage;

        Debug.Log(player.fighterName +
                  "You used " +
                  moveName + "!");

        UpdateHPText();

        if (enemy.hp <= 0)
        {
            Debug.Log("You Win!");
            return;
        }

        EnemyTurn();
    }

    void EnemyTurn()
    {
        player.hp -= enemy.attack;

        Debug.Log(enemy.fighterName +
                  "Enemy attacked!");

        UpdateHPText();

        if (player.hp <= 0)
        {
            Debug.Log("You Lose!");
        }
    }
}



