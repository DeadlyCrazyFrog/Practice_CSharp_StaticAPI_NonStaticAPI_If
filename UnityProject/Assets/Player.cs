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
    [Header("玩家 Player")]
    public GameObject target;
    [Header("喇叭、攻擊音效")]
    public AudioSource AUD;
    public AudioClip Atk_sound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Color P1_color = Color.blue;
        Color P2_color = Color.red;
        Zombie zombie = target.GetComponent<Zombie>();
        string message = "Player " + zombie.HP;

        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log(string.Format("<color=blue>{0}</color>", zombie.HP));
            print(string.Format("<color=blue>{0}</color>", zombie.HP));
        }
    }
}
