using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static int score = 0;
    public static int life = 5;
    public static int energie = 2000;
    public static int sFaktor = 1;
    public static int eFaktor = 5;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (score % 10 < 1 && energie < 1000)
        {
            energie = energie + life;
        }
        updatePanelText(energie, "EnergieText");
        updatePanelText(life, "LifeText");
        updatePanelText(score, "ScoreText");
    }
    public static void updatePanelText(int i, string panel)
    {
        GameObject gaOb = GameObject.Find(panel);
        UnityEngine.UI.Text t = gaOb.GetComponent<UnityEngine.UI.Text>();
        t.text = i.ToString();
    }
}
