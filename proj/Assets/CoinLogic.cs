using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    Status playerStatus;
    public AudioClip coinSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStatus = GameObject.Find("Status").GetComponent<Status>();
    }

    void OnTriggerEnter(Collider touch)
    {
        if (touch.gameObject.CompareTag("Player"))
        {
            playerStatus.AddCoin();
            touch.GetComponent<AudioSource>().PlayOneShot(coinSound);
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
