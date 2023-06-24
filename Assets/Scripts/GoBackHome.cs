using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GoBackHome : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private MeshRenderer _myRenderer;
    private AudioSource _audioSource;
    private bool isPointed;
    private Vector3 scale = new Vector3 (0.2f, 0.0001f, 0.2f);
    private Vector3 scaleInit = new Vector3(0.01f, 0f, 0.01f);
    // Start is called before the first frame update
    void Start()
    {
        _myRenderer = GetComponent<MeshRenderer>();
        _audioSource = transform.parent.parent.GetComponent<AudioSource>();
        transform.parent.localScale = scaleInit;
    }

    // Update is called once per frame
    void Update()
    {
        if (_myRenderer == null)
            return;
        if (isPointed)
            transform.parent.localScale += scaleInit;
        else
            transform.parent.localScale = scale;
        if (transform.parent.localScale.x >= 0.8f)
        {
            Vector3 home = new Vector3(0f, 5f, 0f);
            target.transform.position = home;
            _audioSource.Pause();
        }
    }

    public void OnPointerEnter()
    {
        isPointed = true;
    }

    public void OnPointerExit()
    {
        isPointed = false;
    }
}
