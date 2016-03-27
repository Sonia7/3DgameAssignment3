using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
    // Private INSTANCE VARIABLES


    // PUBLIC INSTANCE VARIABLES
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        // Initialize the audioSources array
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("apple"))
        {
           
           this.gameController.ScoreValue += 100;
        }
     
    }// used when player collides with apple

}
