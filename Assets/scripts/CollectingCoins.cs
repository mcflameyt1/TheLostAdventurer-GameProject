using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{
    public int Coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin Collected");
            Coins = Coins + 1;
            //Col.gameObject.SetActive(false);
            Destroy(Col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
