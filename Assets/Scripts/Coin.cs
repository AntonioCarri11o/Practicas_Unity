using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coin;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(" +1 ");
            coin.PlayOneShot(coin.clip);
            Destroy(this.gameObject);
        }
    }
}
