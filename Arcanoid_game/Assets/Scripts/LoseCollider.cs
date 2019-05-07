using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("kupa");
        Debug.Log("Level load requested for: " + "Lose");
        SceneManager.LoadScene("Lose");
    }


}
