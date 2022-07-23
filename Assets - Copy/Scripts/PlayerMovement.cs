using UnityEngine;
[RequireComponent(typeof(Rigidbody))] //Kesinlikle rigidbodye ihtiyacýmýz var
public class PlayerMovement : MonoBehaviour
{
    // reference for rigidbody component
    [SerializeField]private Rigidbody rb;//private deðiþkenleri editör üzerinden etkilemek için

    // Creating variables
    // Write public to be able to edit on inspector
    public float forwardForce = 2000f; // f signifies that it's a float
    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update
    // Oyun baþladýðýnda çalýþýr
    void Start()
    {
        Debug.Log("Hello, Gamers!");// Wr'tes this to console
        
    }

    // Update is called once per frame / her kare calisir 
    // FixedUpdate daha iyi sonuc veriyor fizik iceren durumlarda
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // time.deltatime tum bilgisayarlarda ayni hizda calismasi icin

        // if pressed on this buttons apply sideways force 
        if (Input.GetKey("d")) // you can also get his inouts in the Update method for faster reactions
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange ); 
            // ForceMode helps us get snappier controls
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // - for the opposite direction
        }

        if (rb.position.y < -2)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
