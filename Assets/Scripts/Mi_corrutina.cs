using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi_corrutina : MonoBehaviour
{
    public GameObject mi_esfera;
    public float tiempo;
    Coroutine coroutine;
    // Start is called before the first frame update
    void Start()
    {
        Apagar();
        StopCoroutine(coroutine);
    }
    public void Apagar()
    {
        coroutine = StartCoroutine (W_Apagar());
    }
    IEnumerator W_Apagar()
    {
        tiempo = Random.Range(0.5f, 3.0f);
        mi_esfera.SetActive(false);
        yield return new WaitForSeconds(tiempo);
        mi_esfera.SetActive(true);
        yield return new WaitForSeconds(tiempo);
        Apagar();
    }
}
