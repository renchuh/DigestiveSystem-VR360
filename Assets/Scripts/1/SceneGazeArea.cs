using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneGazeArea : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        GetComponent<VRButton>().OnGaze.AddListener(() =>
        {
            SceneManager.LoadScene(sceneName);
        });
    }
     
}
