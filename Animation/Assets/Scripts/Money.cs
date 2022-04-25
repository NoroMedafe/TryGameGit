using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private int _costMoney;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent(out Player player))
        {
            player.ApplyMoney(_costMoney);
            Destroy(gameObject);
        }

        if (collision.TryGetComponent(out Money money))
        {
            Destroy(gameObject);
        }

    }
}
