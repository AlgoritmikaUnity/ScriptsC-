using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class scens : MonoBehaviour
{
    public string sceneName;
    public void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
