using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class game_manager : MonoBehaviour {

    public Text sc_ui;
    public Text best_sc_ui;
    public GameObject new_best_ui;
    public GameObject restart_ui;
    public GameObject comfirm_clear_ui;

    private float sc;
    private int best_sc;
    // Use this for initialization
    void Start () {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        if (PlayerPrefs.GetInt("best_score") != null|| PlayerPrefs.GetInt("best_score") !=0)
        {
            best_sc = PlayerPrefs.GetInt("best_score");
            best_sc_ui.text = "" + best_sc;
        }
        else
        {
            best_sc = 0;
            best_sc_ui.text = "" + best_sc;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
         sc = GameObject.FindWithTag("Player").transform.position.z;
        sc_ui.text = ""+(int)sc;
        set_best_score();
        stop_game_late();
        
	}

    public void restart()
    {
        Application.LoadLevel("test_1");
        restart_ui.SetActive(false);
        Time.timeScale = 1;
    }

    public void set_restart()
    {
        restart_ui.SetActive(true);      
    }

    public void set_best_score()
    {
        if ((int)sc > best_sc)
        {
            best_sc = (int)sc;
            new_best_ui.SetActive(true);
            PlayerPrefs.SetInt("best_score",best_sc);
        }
    }

    public void clear_best_score()
    {
        comfirm_clear_ui.SetActive(true);
    }

    public void comfirm_clear(bool x)
    {
        if (x) { PlayerPrefs.DeleteKey("best_score"); comfirm_clear_ui.SetActive(false); }
        if (!x) { comfirm_clear_ui.SetActive(false); }
    }

    

    void stop_game_late()
    {
        if (GameObject.FindWithTag("Player").gameObject.GetComponent<player_health>().health == 0)
        {
            Invoke("stop_game", 0.08f);
        }
    }

    void stop_game()
    {
        Time.timeScale = 0;
        set_restart();
    }
}
