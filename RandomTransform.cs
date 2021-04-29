using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
public class RandomTransform : MonoBehaviour
{

    [Header("Position Settings :")]
    public bool Position = false;
    public float xMinPosition = -1;
    public float xMaxPosition = 1;
    public float yMinPosition = -1;
    public float yMaxPosition = 1;
    public float zMinPosition = -1;
    public float zMaxPosition = 1;

    [Header("Roation Settings :")]
    public bool Roation = false;
    public int xMinRoation = -70;
    public int xMaxRoation = 70;
    public int yMinRoation = -70;
    public int yMaxRoation = 70;
    public int zMinRoation = -70;
    public int zMaxRoation = 70;

    [Header("Scale Settings :")]
    public bool Scale = false;
    public float MinScale = 0.1f;
    public float MaxScale = 1;
    private float ScaleValue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Position == true)
        {
            PositionRandom();
            Debug.Log("Position Random is Excuted");
        }
        if (Position == false)
        {
            Debug.Log("Position Random is Terminated");
        }


        if (Roation == true)
        {
            RotateRandom();
            Debug.Log("Roation Random is Excuted");
        }
        if (Roation == false)
        {
            Debug.Log("Roation Random is Terminated");
        }


        if (Scale == true)
        {
            ScaleRandom();
            Debug.Log("Scale Random is Excuted");
        }
        if (Scale == false)
        {
            Debug.Log("Scale Random is Terminated");
        }

    }

    void PositionRandom()
    {
        transform.position = new Vector3(Random.Range(xMinPosition, xMaxPosition), Random.Range(yMinPosition, yMaxPosition), Random.Range(zMinPosition, zMaxPosition));
    }

    void RotateRandom()
    {
        transform.eulerAngles = new Vector3(Random.Range(xMinRoation, xMaxRoation), Random.Range(yMinRoation, yMaxRoation), Random.Range(zMinRoation, zMaxRoation));
    }

    void ScaleRandom()
    {
        ScaleValue = UnityEngine.Random.Range(MinScale, MaxScale);
        transform.localScale = new Vector3(ScaleValue, ScaleValue, ScaleValue);
    }
}
