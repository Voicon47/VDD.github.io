using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationtest : MonoBehaviour
{    
    public float speed=10;
    public float turnSpeed;
    private float move;
    //public GameObject C;
    //public GameObject Z;
     private Animator animator;
  //  public Rigidbody rigidbody;
    // Start is called before the first frame update
  /*  private void Awake(){
        rigidbody=GetComponent<Rigidbody>();
    }*/
  void Start(){
    animator=GetComponent<Animator>();
   }
    private void FixedUpdate(){
        var verticalInput=Input.GetAxis("Vertical");
        
        var hozirontalInput=Input.GetAxis("Horizontal");

        move=verticalInput *speed* Time.deltaTime;

        var angle=hozirontalInput* Vector3.up;

        var lastangle=angle*turnSpeed;
       transform.Rotate(lastangle);
        //rigidbody.AddTorque(lastangle);
        //rigidbody.AddForce(Vector3.forward *move);
       transform.Translate(Vector3.forward *move);
       if(Input.GetKey(KeyCode.C)){
        Debug.Log("saadssad");
        animator.SetBool("lie",true);
       // C.SetActive(true);
       }else if (Input.GetKey(KeyCode.Z)){
          animator.SetBool("shitdown",true);  
       // Z.SetActive(true);
        //
        Debug.Log("Z ne");
       }else{
         animator.SetBool("shitdown",false);  
         animator.SetBool("lie",false); 
       }
       if (Input.GetMouseButtonDown(0)){
          animator.SetTrigger("Attack");
       }if (Input.GetMouseButtonDown(1)){
          animator.SetTrigger("Attack2");
       }if (Input.GetMouseButtonDown(2)){
          animator.SetTrigger("Attack3");
       }
       
    }
}