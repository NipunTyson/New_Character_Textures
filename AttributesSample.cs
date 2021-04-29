using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Rigidbody))]
public class AttributesSample : MonoBehaviour
{

    public int Five;

    void Update()
    {
        Debug.Log("Hey, I'm working from EditMode!");
    }
    [Header("Main Settings :")]
    public float CharHP = 100f;
    public float CharSpeed = 20f;

    [Header("Weapon Settings :")]
    public float Damage = 50f;

    public float BulletSpeed = 1f;

    public bool AutoReload = false;

    [Range(0, 100)]
    public int OneHundreed = 0;

    [Range(0, 1000)]
    public int OneThousand = 0;

    public string VisibleVar = "";
    [HideInInspector]
    public string InvisibleVar = "";

    [Tooltip("Serialized JSON/XML/Binary data source")]
    public TextAsset DBSource;

    public int foo;
    public int foo2;
    [Space()]
    public int foo3;
    [Space(25)]
    public int foo4;
    public string SomeDefaultText;
    [Multiline()]
    public string SomeShorterText;
    [Multiline(5)]
    public string SomeLongText;

    private string Foo;
    [SerializeField()]
    private string SerializedFoo;

    [ContextMenu("Log Debug Message")]
    public void WriteMsg()
    {
        Debug.Log("Greetings DigitalHamster user! I was called from a Context Menu entry on this Script!");
        Five = 5;
    }

    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}