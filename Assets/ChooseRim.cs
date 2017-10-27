using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRim : MonoBehaviour {

    public GameObject[] objects;
    public Rigidbody _prefabs;
    public void RightClick()
    {

        var obj = GameObject.Find("CountRim");
        var countRim = obj.GetComponent<Text>().text;
        //var parentRim = GameObject.FindWithTag("rims");
        var parentRim = GameObject.FindGameObjectsWithTag("rims");
        var rim = GameObject.FindGameObjectsWithTag(countRim);
        var objClick = GameObject.Find("CountClick");
        var CountClick = Convert.ToInt32(objClick.GetComponent<Text>().text);
        

        //Debug.Log(countRim);
        //Debug.Log(objects.Length);

        //Destroy(objects[0].GetComponent<MeshRenderer>());
        //DestroyImmediate(objects[0]);
        //var rim = GameObject.FindGameObjectWithTag(countRim);
        //Destroy(rim);
        //GameObject new_rim = Instantiate(objects[0], objects[0].transform.position, rot, parentRim.transform );
        //var rim1 = GameObject.FindGameObjectsWithTag(countRim);
        //var rim2 = GameObject.FindGameObjectsWithTag(countRim+  1);

        //if (CountClick == 1)
        //{
            if (Convert.ToInt32(countRim) < objects.Length) {

                for (int i = 0; i < parentRim.Length; i++)
                {            
                    Vector3 pos = rim[i].transform.position;
                    Quaternion rot = rim[i].transform.rotation; 
                    if (i==0)
                    {
                    GameObject new_rim = Instantiate(objects[Convert.ToInt32(countRim)], pos, rot, parentRim[i].transform);
                    new_rim.GetComponent<MeshRenderer>().enabled = false;
                    }
                    else
                    {
                        Instantiate(objects[Convert.ToInt32(countRim)], pos, rot, parentRim[i].transform);
                    }
                }
                for (int i = 0; i < rim.Length; i++)
                {
                    Destroy(rim[i]);
                }
                obj.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(obj.GetComponent<Text>().text) + 1);
            }
        //}
        //else
        //{
        //    if (Convert.ToInt32(countRim) < objects.Length)
        //    {
            
        //        for (int i = 1; i < parentRim.Length; i++)
        //        {
                    
        //            //obj = GameObject.Find("CountRim");
        //            //countRim = obj.GetComponent<Text>().text;
        //            //rim = GameObject.FindGameObjectsWithTag(countRim);              
        //            Vector3 pos = rim[i-1].transform.position;
        //            Quaternion rot = Quaternion.Euler(-90f, 0, 0);
        //            //GameObject new_rim = Instantiate(objects[Convert.ToInt32(countRim) - 1], objects[Convert.ToInt32(countRim) - 1].transform.position, rot, parentRim[i].transform);
        //            GameObject new_rim = Instantiate(objects[Convert.ToInt32(countRim)], pos, rot, parentRim[i].transform);
        //        }
        //        for (int i = 0; i < rim.Length; i++)
        //        {
        //            Destroy(rim[i]);
        //        }
        //        Debug.Log(obj.GetComponent<Text>().text);
        //        obj.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(obj.GetComponent<Text>().text) + 1);
        //        Debug.Log(obj.GetComponent<Text>().text);
        //    }
        //}

    }
    
    public void LeftClick()
    {
        var obj = GameObject.Find("CountRim");
        var countRim = obj.GetComponent<Text>().text;
        var parentRim = GameObject.FindGameObjectsWithTag("rims");
        Vector3 pos = new Vector3(0, 0, 0);
        Quaternion rot = Quaternion.Euler(0, 0, 0);
        Debug.Log(countRim);
        if (Convert.ToInt32(countRim) > 1)
        {
            var rim = GameObject.FindGameObjectsWithTag(countRim);
            obj.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(obj.GetComponent<Text>().text) - 1);
            countRim = obj.GetComponent<Text>().text;
            for (int i = 0; i < parentRim.Length; i++)
            {
                pos = rim[i].transform.position;
                rot = rim[i].transform.rotation;

                if (i == 0)
                {
                    GameObject new_rim = Instantiate(objects[Convert.ToInt32(countRim) - 1], pos, rot, parentRim[i].transform);
                    new_rim.GetComponent<MeshRenderer>().enabled = false;
                }
                else
                {
                    Instantiate(objects[Convert.ToInt32(countRim) - 1], pos, rot, parentRim[i].transform);
                }


                

            }
            for (int i = 0; i < rim.Length; i++)
            {
                Destroy(rim[i]);
            }
        }
    }
}
