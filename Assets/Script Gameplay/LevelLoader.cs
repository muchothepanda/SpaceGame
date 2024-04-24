using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{

    public Player player;
    public Enemy enemy;
    public Weapon weapon;
    public ExplodingEnemy explodingEnemy;
    private float speedToCreateThePlayer;

    public static int difficulty;

    // Start is called before the first frame update
    void Start()
    {
       
       //player =new Player(speedToCreateThePlayer);
       
       // player.health= new Health(100);
       // player.weapon = new Weapon();
       
       // enemy = new Enemy("bad");
       // explodingEnemy = new ExplodingEnemy("boom");
        int result = Utilities.SumUpNumbers(2, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        //enemy = new Enemy("bad");
    }

    private void OnTriggerEnter(Collider other)
    {

    }


}
