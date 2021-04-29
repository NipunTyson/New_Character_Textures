using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaterialColor : MonoBehaviour
{
    private RenderBuffer _renderer;
    private int materialCount = 1;
    public Gradient SourceGradiant;
    private int gradientColorKeyCount; //2

    void Start()
    {
        gradientColorKeyCount = SourceGradiant.colorKeys.Length; //2
        RandomColor();
    }

    void Update()
    {
        RandomColor();
    }

    void RandomColor()
    {
        for (int i =0;i < materialCount; i++)
        {
            GetComponent<Renderer>().material.color = SourceGradiant.Evaluate(Random.Range(0f, 1f)); //1
            //GetComponent<Renderer>().material.color = SourceGradiant.Colorskeys[Random.Range(0f, gradientColorKeyCount)].color; //2
            //GetComponent<Renderer>().material.color = Random.ColorHSV(); //3
        }
    }
}
