using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo360View : MonoBehaviour
{
    /// <summary>
    /// The material to use when this object is inactive (not being gazed at).
    /// </summary>
    public Vector3 translation = new Vector3(20f, 2f, 0f);
    public GameObject target;
    private Renderer _myRenderer;

    // Start is called before the first frame update
    public void Start()
    {
        _myRenderer = GetComponent<Renderer>();
    }

    public void OnPointerEnter()
    {
        target.transform.position = translation;
    }
        public void OnPointerExit()
    {
        
    }
}
