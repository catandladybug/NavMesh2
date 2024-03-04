using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {

        if (col.name == "Player")
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
