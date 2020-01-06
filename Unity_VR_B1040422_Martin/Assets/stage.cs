using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class stage : MonoBehaviour
{
    Animator anim;
    int HP = 3;
    int state=1;
    public GameObject shoot,bullettimeeffect,HpBar,win;
    [Header("射擊時間長度")]
    public int timer = 50;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = shoot.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        showHP();

        bulletTimeOver();
   


        

        switch (state)
        {
            case 1:
                Invoke("stateturntwo", 3);
                break;
            case 2:
                shoot.GetComponent<shoot>().enabled = true;
                anim.SetBool("shoot", true);              
                InvokeRepeating("timergo", 1, 1);
                break;
            case 3:

                break;
            case 4:
                Destroy(shoot.GetComponent<shoot>());
                anim.SetBool("dead", true);
                Invoke("winla", 4);
                break;
        }
    }


    /// <summary>
    /// 子彈時間
    /// </summary>
    public void bulletTime()
    {
        Time.timeScale = 0.2f;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        bullettimeeffect.SetActive(true);
    }

    /// <summary>
    /// 恢復正常時間
    /// </summary>
     void bulletTimeOver()
    {
        Time.timeScale += 1 * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
        bullettimeeffect.SetActive(false);
    }

    /// <summary>
    /// wtf
    /// </summary>
    void stateturntwo()
    {
        state=2;
    }

    /// <summary>
    /// 計時器
    /// </summary>
    void timergo()
    {
        timer = timer - 1;
        if (timer < 0)
        {
            state=4;
        }
    }

    /// <summary>
    /// 被打中
    /// </summary>
    public void gotHit()
    {
        HP = HP - 1;
        if(HP <= 0)
        {
            SceneManager.LoadScene("matrix");
        }
    }

    /// <summary>
    /// 顯示HP
    /// </summary>
    void showHP()
    {
        Text myHP =  HpBar.GetComponent<Text>();
        myHP.text = "your hp = "+HP;
    }

    void winla()
    {
        win.SetActive(true);
        Invoke("reload", 5);
    }

    void reload()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
