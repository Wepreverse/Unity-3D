using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	Rigidbody PlayerRigidBody;
    public Rigidbody bullet;
    Rigidbody bulletClone;
    int HP;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
        HP=100;

    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = Input.GetAxis("Vertical");
        PlayerRigidBody.AddForce(transform.forward * moveVertical * 20f);

        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0,moveHorizontal*10f,0);

        if(Input.GetKeyDown("space")){
            bulletClone = Instantiate(bullet, new Vector3(transform.position.x+2,transform.position.y,transform.position.z), transform.rotation);
            bulletClone.AddForce(transform.forward*1000f);
        }
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="Enemy"){
            HP = HP - 20;
            txt.text="Health :"+HP;
            if(HP ==0){
               SceneManager.LoadScene(1);
            }
            Debug.Log(HP);
            
        }
    }
}
