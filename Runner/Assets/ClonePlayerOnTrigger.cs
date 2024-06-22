using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePlayerOnTrigger : MonoBehaviour
{
    public GameObject playerPrefab; // Klonlanacak player prefab
    public Transform spawnPoint; // Klonun oluþturulacaðý nokta
    public List<GameObject> clones = new List<GameObject>();

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Entered"); // Konsolda kontrol etmek için log yazdýrýlýr

            // Player prefab'ýný spawnPoint konumunda ve dönüþünde klonla
            GameObject clone = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
