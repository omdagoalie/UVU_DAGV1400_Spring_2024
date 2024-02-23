using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Script6_Scope : MonoBehaviour
{
    //SCOPE AND ACCESS MODIFIERS
    /*
    public int alpha = 5;
    private int beta = 0;
    private int gamma = 5;
    private AnotherClass myOtherClass;
    
    void Start ()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
     
    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    
    void Update ()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
    */
    
    //ANOTHER CLASS
    public int apples;
    public int bananas;
    private int stapler;
    private int stellotape;

    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("fruit total: " + answer);
    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
