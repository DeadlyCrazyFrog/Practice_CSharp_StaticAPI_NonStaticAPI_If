using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [Header("血量")]
    [Range(0f, 100f)]
    public float HP = 1.5F;
    [Header("攻擊力")]
    [Range(0f, 50f)]
    public float ATK = 30f;
    [Header("殭屍")]
    public GameObject Zb;
    [Header("喇叭、攻擊音效")]
    public AudioSource Aud;
    public AudioClip Atk_sound;
    private bool deadspot=false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Zombie zombie = Zb.GetComponent<Zombie>();

        if (HP <= 0 && deadspot == false)
        {
            deadspot = true;
            print(string.Format("<color=blue>{0}</color>", "屁孩死了"));
        }
        if (Input.GetKeyDown(KeyCode.A) && HP > 0 && zombie.HP > 0)
        {
            zombie.HP -= ATK;
            if (zombie.HP <= 0)
            {
                zombie.HP = 0;

            }
            Aud.PlayOneShot(Atk_sound);
            print(string.Format("<color=red>{0}</color>", "殭屍的血減少" + ATK));
            print(string.Format("<color=red>{0}</color>", "殭屍的血剩下" + zombie.HP));


        }
    }
}
