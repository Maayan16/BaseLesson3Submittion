using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionals: MonoBehaviour
{
    /*
    First Assignment:
    Create a method that accepts an integer, operates it and prints out the result.
    Create a method that accepts an integer, with an if statement about this integer.
    Print something inside the if body, and inside the else body.
    Create a method that accepts an integer, with a switch statement with 3 cases about this integer. Print something in the cases.
    */
    // Start is called before the first frame update
    void int_operate(int var){
        Debug.Log(var + 2);
    }

    void if_operate(int var){
        if(var % 2 == 0){
            Debug.Log("var is even");
        }
    }
    
    void switch_operate(int var){
        switch(var) 
        {
        case 1:
            Debug.Log("The value of the variable is 1");
            break;
        case 2:
            Debug.Log("The value of the variable is 2");
            break;
        case 3:
            Debug.Log("The value of the variable is 3");
            break;
        default:
            Debug.Log("The value of the variable is not 1 / 2 /3 ");
            break;
        }
    }
    void Start()
    {
        int_operate(3);
        if_operate(4);
        if_operate(5);
        switch_operate(1);
        switch_operate(5);
    }
}
