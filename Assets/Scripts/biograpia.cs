using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biograpia : MonoBehaviour
{
    // Start is called before the first frame update

    string name = "Alex";

    string lastname = "chogovadze";

    string myAge = 13;

    string myHobby = "prodramist";

    void Start()
    {
        int GetFullName(name, lastname)
        Debug.Log("Alex chogovadze");

        int GetFullBio("my name alex,lastname chogovadze, myAge 13,myHobby prodramist");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw(" Horizontal");
        float vertical = Input.GetAxisRaw(" Vertical");

        if (horizontal == 1)
        {
            Debug.Log(alexandre);
        }
        else if (horizontal == -1)
        {
            Debug.Log("age 13");
        }
        else if (vertical == 1)
        {
            Debug.Log("lastname chogovadze");
        }
        else
        {
            Debug.Log("myHobby programist");
        }

















    }
}
