using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    SpriteRenderer m_renderer;
    public GameObject collectible;
    public GameObject background;
    public GemChecker gem;
    public string teleportDestination;

    private void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            
        }

        if (col.gameObject.tag == "Player" && gem.green == true)
        {

        }

        if (col.gameObject.tag == "Player" && gem.blue == true)
        {

        }

        if (col.gameObject.tag == "Player" && gem.red == true)
        {

        }

        if (col.gameObject.tag == "Player" && gem.green == true && gem.blue == true)
        {

        }

        if (col.gameObject.tag == "Player" && gem.green == true && gem.red == true)
        {

        }

        if (col.gameObject.tag == "Player" && gem.blue == true && gem.red == true)
        {

        }

        if(col.gameObject.tag == "Player" && gem.green == true && gem.blue == true && gem.red == true)
        {
            SceneManager.LoadScene(teleportDestination);
        }

    }
}
