using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        Vector3 v = Vector3.up * Mathf.Sin(Time.time * 5 * Mathf.PI) / 200;
        transform.position += v;
    }

}

