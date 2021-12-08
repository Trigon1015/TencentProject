using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject HealthBar;
    public GameObject menu;
    public GameObject uimanager;

    public GameObject savepoint;
    //public GameObject player;
    private  int scene;
    private float x;
    private float y;
    private float z;
    private float xx;
    private float yy;
    private float zz;
    public static bool isload;

    public void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        //DontDestroyOnLoad(player);
        //DontDestroyOnLoad(uimanager );
        isload = false;
        

    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGmae()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void SaveGame()
    {
        savedata();
    }
    public void Load()
    {
        loadscene();
        loadsmall();
        if (SceneManager.GetActiveScene().buildIndex > scene || SceneManager.GetActiveScene().buildIndex < scene)
        {
            SceneManager.LoadScene(scene);
        }
        Time.timeScale = 1;
        loadhealth();
        X();
        Y();
        Z();
        loadjump();
        loadsheild();
        LoadPosition();
        

    }
    public void LoadGame()
    {
        
        loadscene();
        if(SceneManager.GetActiveScene().buildIndex>scene|| SceneManager.GetActiveScene().buildIndex<scene )
        {
            SceneManager.LoadScene(scene);
            
            
        }
        ResumeGame();
        loadhealth();
       
        X();
        Y();
        Z();
        
        
       LoadPosition();

        Debug.Log(PlayerPrefs.GetInt("small"));
        Debug.Log(PlayerController.small);
    }
    public void LoadPosition()
    {
        PlayerManager.postion = new Vector3(x, y, z);
        isload = true;
    }
    public void savedata()
    {
        PlayerPrefs.SetFloat("playerhealth", PlayerManager.PlayerMaxHP);
        PlayerPrefs.SetInt("scene", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetFloat("x", xx);
        PlayerPrefs.SetFloat("y", yy);
        PlayerPrefs.SetFloat("z", zz);Debug.Log(xx);
        PlayerPrefs.SetInt("small", PlayerController.small);
        PlayerPrefs.SetInt("jump", PlayerController.availableJumps);
        PlayerPrefs.SetInt("sheild", PlayerController.sheild );
    }

    private void Update()
    {
        xx = PlayerManager.postion.x;
        yy = PlayerManager.postion.y;
        zz = PlayerManager.postion.z;
        //Debug.Log(xx);
    }

    public float loadhealth()
    {
        
        PlayerManager.PlayerHP = PlayerPrefs.GetFloat("playerhealth");
        return PlayerManager.PlayerHP;

    }
    public int loadsmall()
    {
        PlayerController.small= PlayerPrefs.GetInt("small");
        return PlayerController.small;
    }
    public int loadjump()
    {
        PlayerController.availableJumps  = PlayerPrefs.GetInt("jump");
        return PlayerController.availableJumps;
    }
    public int loadsheild()
    {
        PlayerController.sheild = PlayerPrefs.GetInt("jump");
        return PlayerController.sheild;
    }
    public int loadscene()
    {

        scene = PlayerPrefs.GetInt("scene");
        return scene;

    }
    public float X()
    {
        x = PlayerPrefs.GetFloat("x");
        return x;

    }
    public float Y()
    {
        y = PlayerPrefs.GetFloat("y");
        return y;
    }
    public float Z()
    {
        z = PlayerPrefs.GetFloat("z");
        return z;
    }
}
