using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();
        myPlayer.Attack(50);
        myPlayer.Status();
        myPlayer.Damage(30);
        myPlayer.Status();
        myPlayer.Magic(100);
        myPlayer.Status();
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Player
{
    private int hp = 100;
    private int mp = 100;

    public void Attack(int power)
    {
        Debug.Log(power + "のダメージを与えた！");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた！");
    }

    public void Magic(int power)
    {
        this.mp -= 20;
        Debug.Log("魔法を唱えた！");
        Debug.Log(power + "のダメージを与えた!");
    }

    public void Status()
    {
        Debug.Log("HP: " + this.hp + " / MP: " + this.mp);
    }
}