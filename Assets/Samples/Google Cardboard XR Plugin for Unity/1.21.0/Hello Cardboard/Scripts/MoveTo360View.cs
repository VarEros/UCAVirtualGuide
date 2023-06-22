using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MoveTo360View : MonoBehaviour
{
    /// <summary>
    /// The material to use when this object is inactive (not being gazed at).
    /// </summary>
    [SerializeField] private GameObject target;
    [SerializeField] private Vector3 teleportPose;
    private MeshRenderer _myRenderer;
    //private Vector3 teleportPose;

    private bool colorChaning = false;
    private float myTimer = 0f;

    // Start is called before the first frame update
    public void Start()
    {
        _myRenderer = GetComponent<MeshRenderer>();
        //teleportPose = new Vector3(sphere.transform.position.x, sphere.transform.position.y, sphere.transform.position.z)
    }

    public void Update()
    {
        if (colorChaning) {
            myTimer += Time.deltaTime;
            if (myTimer >= 2f)
            {
                target.transform.position = teleportPose;
            }
        }
    }

    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    public void OnPointerExit()
    {
        GazeAt(false);
    }

    public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            colorChaning = true;
        }
        else
        {
            myTimer = 0f;
            colorChaning = false;
        }
    }
}
