using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePlayerOnTrigger : MonoBehaviour
{
    public GameObject playerPrefab; // Klonlanacak player prefab
    public Transform spawnPoint; // Klonun olu�turulaca�� nokta
    public List<GameObject> clones = new List<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Entered"); // Konsolda kontrol etmek i�in log yazd�r�l�r

            // Player prefab'�n� spawnPoint konumunda ve d�n���nde klonla
            GameObject clone = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
