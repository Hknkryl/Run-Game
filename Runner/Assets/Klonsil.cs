using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Klonsil : MonoBehaviour
{
    public class DeleteClonesOnTrigger : MonoBehaviour
    {
        public ClonePlayerOnTrigger cloneScript; // Klonlar� tutan script
        public int deleteCount = 1; // Silinecek klon say�s�

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("WrongTrigger"))
            {
                Debug.Log("Wrong Trigger Entered"); // Konsolda kontrol etmek i�in log yazd�r�l�r

                for (int i = 0; i < deleteCount && cloneScript.clones.Count > 0; i++)
                {
                    GameObject cloneToDelete = cloneScript.clones[cloneScript.clones.Count - 1]; // Listenin sonundaki klonu se�
                    cloneScript.clones.RemoveAt(cloneScript.clones.Count - 1); // Listeden kald�r
                    Destroy(cloneToDelete); // Klonu yok et
                }
            }
        }
    }
}