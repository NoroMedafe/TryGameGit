using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private TMP_Text[] _textMesh;

    private int _money;
    private void Start()
    {
        _textMesh[0].text = "Health:" + _health;
        _textMesh[1].text = "Money:" + _money;

    }

    public void ApplyDamage (int damage)
    {

        if (_health<= 0)
        {
            Die();
        }

        _health -= damage;
        _textMesh[0].text = "Health:" + _health;
    }
    public void ApplyMoney(int costMoney)
    {
        _money += costMoney;
        _textMesh[1].text = "Money:" + _money;

    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
