using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stickHelper : MonoBehaviour
{
    public GameObject instance;
    // Start is called before the first frame update
    void Start()
    {

        SceneManager.MoveGameObjectToScene(instance, SceneManager.GetActiveScene());
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
