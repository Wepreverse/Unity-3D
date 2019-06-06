using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class EnemyScript : MonoBehaviour
{	
	NavMeshAgent myNavMeshAgent;
	public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        myNavMeshAgent.SetDestination(Player.transform.position);
    }
    
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="Bullet"){
            Destroy(gameObject);
            Destroy(col.gameObject);
            ScoreScript.Score++;
            Debug.Log("+1");
            
        }
    }
}
