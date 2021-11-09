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
        SceneManager.LoadScene(0);
    }

    public void SaveGame()
    {
        savedata();
    }
    public void Load()
    {
        loadscene();
        if (SceneManager.GetActiveScene().buildIndex > scene || SceneManager.GetActiveScene().buildIndex < scene)
        {
            SceneManager.LoadScene(scene);

            Debug.Log("1");
        }
        Time.timeScale = 1;
        loadhealth();

        X();
        Y();
        Z();


        LoadPosition();
        Debug.Log("2");

    }
    public void LoadGame()
    {
        
        loadscene();
        if(SceneManager.GetActiveScene().buildIndex>scene|| SceneManager.GetActiveScene().buildIndex<scene )
        {
            SceneManager.LoadScene(scene);
            
            Debug.Log("1");
        }
        ResumeGame();
        loadhealth();
       
        X();
        Y();
        Z();
        
        
       LoadPosition();
        Debug.Log("2");
        

    }
    public void LoadPosition()
    {
        PlayerManager.postion = new Vector3(x, y, z);
        isload = true;
    }
    public void savedata()
    {
        PlayerPrefs.SetFloat("playerhealth", PlayerManager.PlayerHP);
        PlayerPrefs.SetInt("scene", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.SetFloat("x", xx);
        PlayerPrefs.SetFloat("y", yy);
        PlayerPrefs.SetFloat("z", zz);Debug.Log(xx);
       
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
        if (PlayerPrefs.HasKey("playerhealth"))
        {
            PlayerPrefs.SetFloat("playerhealth", 100f);
        }
        PlayerManager.PlayerHP = PlayerPrefs.GetFloat("playerhealth");
        return PlayerManager.PlayerHP;

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
