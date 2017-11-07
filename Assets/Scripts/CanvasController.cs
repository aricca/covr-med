﻿using UnityEngine;
using System.Collections;
using System.Xml;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {

    // Instructions for the standing person (moving in the OR), loaded from a language file
    XmlDocument instructionsDoc;
    XmlNode root;

    // Use this for initialization
    void Start () {
        instructionsDoc = new XmlDocument();
        instructionsDoc.Load("Assets/Scripts/french.xml");
        root = instructionsDoc.FirstChild;

        // This is how to access the different instructions

        //if (root.HasChildNodes) {
        //    for (int i = 0; i < root.ChildNodes.Count; i++) {
        //        Debug.Log(root.ChildNodes[i].InnerText);
        //    }
        //}

        gameObject.GetComponentInChildren<Text>().text = root.ChildNodes[0].InnerText;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
