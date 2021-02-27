using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Text DisplayInfo;

    Rigidbody player;
    public AudioSource Info;
    void Start()
    {
        Info = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.CompareTag("roudy"))
        {
           // Col.gameObject.SetActive(false);
            Info.Play();
        }
    }
}
