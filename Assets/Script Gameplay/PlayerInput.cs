using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInput : MonoBehaviour
{
    public Camera maincamera;
    private Player player;
    public Vector2 direction;
    public float Angletorotate;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

       

        Angletorotate= Mathf.Atan2(direction.y - transform.position.y ,direction.x - transform.position.x) *Mathf.Rad2Deg;  
        direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,-10));
        player.Move( new Vector2(horizontalInput,verticalInput), Angletorotate);  

    }
    private void Update()
    {
       
        if(Input.GetMouseButtonDown(0))
        {
            player.Shoot();
        } 
    }
}
