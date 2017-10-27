using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotation : MonoBehaviour {

    public bool Rotation;



    public void FixedUpdate()
    {
        if (Rotation)
        { 
        Quaternion y = Quaternion.AngleAxis(1, Vector3.up);
        transform.rotation *= y;
        }
    }
    //public void rotation_rim() {
    //    //GameObject rim = GameObject.Find("vossen");
    //    //var rim = GameObject.FindGameObjectsWithTag("2");

    //    var obj = GameObject.Find("CountRim");
    //    var countRim = obj.GetComponent<Text>().text;
    //    var rim = GameObject.FindGameObjectsWithTag(countRim);
    //    rotation script_rotation = rim[1].GetComponent<rotation>();

    //    if (script_rotation.enabled==true)
    //    {
    //        script_rotation.enabled = false;
    //    } 
    //    else
    //    {
    //        script_rotation.enabled = true;
    //    }
    //}

    public void change_rotation()
    {
        //var obj = GameObject.Find("CountRim");
        //var countRim = obj.GetComponent<Text>().text;
        var rim = GameObject.FindGameObjectsWithTag("rims");

        Debug.Log(rim.Length);


        rotation script_rotation = rim[1].GetComponent<rotation>();
        Rotation = script_rotation.Rotation;

        if (Rotation)
        {
            script_rotation.Rotation = false;
        }
        else
        {
            script_rotation.Rotation = true;
        }

        for (int i = 2; i < rim.Length; i++)
        {


            rotation script_rotation1 = rim[i].GetComponent<rotation>();
            if (Rotation)
            {
                script_rotation1.Rotation = false;
            }
            else
            {
                script_rotation1.Rotation = true;
            }
        }
    }
}
