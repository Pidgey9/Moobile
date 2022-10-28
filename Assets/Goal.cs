using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("Finish").GetComponent<TextMeshProUGUI>().enabled = true;
            Destroy(GameObject.Find("Player"));
        }
    }
    private void Update()
    {
        if (GameObject.Find("Player") == null && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
    }
}
