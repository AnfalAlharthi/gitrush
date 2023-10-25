using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private int coinCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            CollectCoin(other.gameObject);
        }
    }

    private void CollectCoin(GameObject coin)
    {
        coin.SetActive(false); // ����� ������ �� ������ �� ���� �������
        coinCount++; // ����� ��� ������� ���� ������ �������

        // ����� ��� ����� �� ������� ������ �� ����� ����� ������ ��� ������
    }
}
