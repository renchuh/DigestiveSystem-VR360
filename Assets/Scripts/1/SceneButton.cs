using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public string nextScene;
    void Start()
    {
        GetComponent<VRButton>().OnGaze.AddListener(() =>
        {
            SceneManager.LoadScene(nextScene);
        });
    }

   
}
