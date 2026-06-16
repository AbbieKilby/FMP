using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public int playerHP = 100;
    public int enemyHP = 50;

    public TextMeshProUGUI battleText;

    public void AttackEnemy()
    {
        enemyHP -= 10;

        if (enemyHP <= 0)
        {
            battleText.text = "You Win!";
            return;
        }

        playerHP -= 5;

        battleText.text =
            "You attacked!\n" +
            "Enemy HP: " + enemyHP + "\n" +
            "Player HP: " + playerHP;

        if (playerHP <= 0)
        {
            battleText.text = "You Lost!";
        }
    }
}
