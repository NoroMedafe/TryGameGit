using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private TMP_Text[] _textMesh;

    private int _money;
    private float _posX;
    private float speed;

    private void Start()
    {
        _textMesh[0].text = "Health:" + _health;
        _textMesh[1].text = "Money:" + _money;
        _posX = transform.position.x;
    }

    public float GetSpeed()
    {
        speed = (transform.position.x - _posX) / Time.deltaTime;
        _posX = transform.position.x;
        return speed = Mathf.Abs(speed);
    }

    public void TakeDamage (int damage)
    {

        if (_health<= 0)
        {
            Die();
        }

        _health -= damage;
        _textMesh[0].text = "Health:" + _health;
    }

    public void TakeMoney(int costMoney)
    {
        _money += costMoney;
        _textMesh[1].text = "Money:" + _money;

    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
