using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcoScript : MonoBehaviour
{
    public GameObject Disc;
    public GameObject player1;
    public GameObject player2;

    public int playerNumber;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.Equals(Disc))
        {
            Debug.Log("Disc entered arco");
            if(playerNumber == 1)
            {
                Points.player2points++;
            }
            else if (playerNumber == 2)
            {
                Points.player1points++;
            }
            Debug.Log("Jugador 1: " + Points.player1points + 
                    "\nJugador 2: " + Points.player2points);


            Disc.GetComponent<Rigidbody>().isKinematic = true;
            Disc.transform.position = new Vector3(0, 0.2f, 0);
            Disc.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
