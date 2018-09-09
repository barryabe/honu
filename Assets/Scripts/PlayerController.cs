using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public int successCount;
    private Rigidbody2D rb2d;

    private KeyCode lastPressed = KeyCode.W;
    private int aCount;
    private int dCount;

    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
        aCount = dCount = 0;
        Debug.Log(Manager.Instance.myGlobalVar);
    }

    void Update(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = movement*speed;

        if(checkWinStatus()){
            Debug.Log("You Win!");
        }
    }

    bool checkWinStatus() {
        if (Input.GetKeyDown(KeyCode.A) && lastPressed != KeyCode.A) {
            aCount++;
            Debug.Log("A " + aCount);
            lastPressed = KeyCode.A;
        }
        else if(Input.GetKeyDown(KeyCode.D) && lastPressed != KeyCode.D) {
            dCount++;
            Debug.Log("D " + dCount);
            lastPressed = KeyCode.D;
        }

        if(aCount + dCount >= successCount){
            return true;
        }
        return false;
    } 
}
