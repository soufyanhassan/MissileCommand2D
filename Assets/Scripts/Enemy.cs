using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public Transform target; //set target from inspector instead of looking in Update
    [SerializeField]
    private float speed = 3f;
    private int scoreValue = 12;
    public GameObject explosion;

    void Start()
    {
        //
    }

    void Update()
    {
        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self); //correcting the original rotation

        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {
            //move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        //Debug.Log("hit");
        Destroy(gameObject);
        ScoreManager.score += scoreValue;
        Instantiate(explosion, this.transform.position, this.transform.rotation);

        if (coll.gameObject.tag == "Player")
        {
            Application.LoadLevel("gameover");
        }
    }
}