﻿/*===============================================================================
Copyright (c) 2016-2017 PTC Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using System.Collections.Generic;

public class SamplesAboutScreenInfo
{

    #region PRIVATE_MEMBERS

    readonly Dictionary<string, string> titles;
    readonly Dictionary<string, string> descriptions;

    #endregion // PRIVATE_MEMBERS


    #region PUBLIC_METHODS

    public string GetTitle(string titleKey)
    {
        return GetValuefromDictionary(titles, titleKey);
    }

    public string GetDescription(string descriptionKey)
    {
        return GetValuefromDictionary(descriptions, descriptionKey);
    }

    #endregion // PUBLIC_METHODS


    #region PRIVATE_METHODS

    string GetValuefromDictionary(Dictionary<string, string> dictionary, string key)
    {
        if (dictionary.ContainsKey(key))
        {
            string value;
            dictionary.TryGetValue(key, out value);
            return value;
        }

        return "Key not found.";
    }

    #endregion // PRIVATE_METHODS


    #region CONSTRUCTOR

    public SamplesAboutScreenInfo()
    {

        // Init our Title Strings

        titles = new Dictionary<string, string>()
        {
            { "ImageTargets", "Image Targets" },
            { "VuMark", "VuMark" },
            { "CylinderTargets", "Cylinder Targets" },
            { "MultiTargets", "Multi Targets" },
            { "UserDefinedTargets", "User Defined Targets" },
            { "ObjectReco", "Object Reco" },
            { "CloudReco", "Cloud Reco" },
            { "VirtualButtons", "Virtual Buttons" }
        };

        // Init our Common Cache Strings

        string keyFunctionality = "<size=26>Key Functionality:</size>";
        string targets = "<size=26>Targets:</size>";
        string instructions = "<size=26>Instructions:</size>";
        string footer =
            "<size=26>Terms of Use:</size>\n" +
            "https://developer.vuforia.com/legal/EULA" +
            "\n\n" +
            "© 2016-2017 PTC Inc. All Rights Reserved.";

        // Init our Description Strings

        descriptions = new Dictionary<string, string>();

        // Image Targets

        descriptions.Add("ImageTargets",
            "\nThe Image Targets sample shows how to detect an image " +
            "target and render a simple 3D object on top of it.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Simultaneous detection and tracking of multiple targets\n" +
            "• Load and activate multiple device databases\n" +
            "• Activate Extended Tracking\n" +
            "• Manage camera functions: flash and continuous autofocus\n" +
            "\n" +
            targets + "\n" +
            "• Included Targets\n" +
            "\n" +
            instructions + "\n" +
            "• Point camera at target to view\n" +
            "• Single tap to focus\n" +
            "• Double tap to access options menu\n" +
            "\n" +
            footer + "\n");


        // VuMark

        descriptions.Add("VuMark",
            "\nThe VuMark sample shows how to detect and track VuMarks.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Simultaneous detection and tracking of multiple VuMarks\n" +
            "• Load and activate a VuMark target\n" +
            "• Activate Extended Tracking\n" +
            "• Render an outline when a VuMark is detected\n" +
            "\n" +
            targets + "\n" +
            "• Included VuMarks\n" +
            "\n" +
            instructions + "\n" +
            "• Point device at VuMark\n" +
            "• Single tap to focus\n" +
            "• Double tap to access options menu\n" +
            "• Tap window showing VuMark ID to dismiss\n" +
            "\n" +
            footer + "\n");


        // Cylinder Targets

        descriptions.Add("CylinderTargets",
            "\nThe Cylinder Targets sample shows how to detect a cylindrical " +
            "target and animate a 3D object around the circumference of the cylinder.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Detection and tracking of a cylinder target\n" +
            "• Occlusion handling\n" +
            "\n" +
            targets + "\n" +
            "• Included Target\n" +
            "\n" +
            "To view print target and wrap around a standard soda can.\n" +
            "\n" +
            instructions + "\n" +
            "• Point camera at target to view\n" +
            "• Single tap to focus\n" +
            "\n" +
            footer + "\n");


        // Multi Targets

        descriptions.Add("MultiTargets",
            "\nThe Multi Targets sample shows how to detect a simple cuboid 3D shape " +
            "and animate a 3D object around the shape.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Detection and tracking of cuboid 3D shape\n" +
            "• Occlusion handling\n" +
            "\n" +
            targets + "\n" +
            "• Included Target\n" +
            "\n" +
            instructions + "\n" +
            "• Point camera at target to view\n" +
            "• Single tap to focus\n" +
            "\n" +
            footer + "\n");


        // User Defined Targets

        descriptions.Add("UserDefinedTargets",
            "\nThe User Defined Targets sample shows how to capture and create an " +
            "image target at runtime from user-selected camera video frames.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Create and manage user defined image target\n" +
            "• Activate Extended Tracking\n" +
            "\n" +
            instructions + "\n" +
            "• Hold device parallel to feature rich target and tap camera button\n" +
            "• Single tap to focus\n" +
            "• Double tap to access options menu\n" +
            "\n" +
            footer + "\n");


        // Object Reco

        descriptions.Add("ObjectReco",
            "\nThe Object Recognition sample shows how to recognize and track an object.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Recognize and track up to 2 objects simultaneously\n" +
            "• Activate Extended Tracking\n" +
            "• Manage camera functions: flash\n" +
            "\n" +
            targets + "\n" +
            "• Included Target\n" +
            "\n" +
            instructions + "\n" +
            "• Point camera at target to view\n" +
            "• Single tap to focus\n" +
            "• Double tap to access the options menu\n" +
            "\n" +
            footer + "\n");


        // Cloud Reco

        descriptions.Add("CloudReco",
            "\nThe Cloud Reco sample shows how to use the cloud recognition service to " +
            "recognize targets located in a cloud database.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Manage detection and tracking of cloud based image targets\n" +
            "• Activate Extended Tracking\n" +
            "\n" +
            targets + "\n" +
            "• Included Targets\n" +
            "\n" +
            instructions + "\n" +
            "• Point camera at target to view\n" +
            "• Single tap to focus\n" +
            "• Double tap to access options menu\n" +
            "\n" +
            footer + "\n");


        // Virtual Buttons

        descriptions.Add("VirtualButtons",
            "\nThe Virtual Buttons sample shows how the developer can define rectangular " +
            "regions on image targets that trigger an event when touched or occluded in " +
            "the camera view. The sample renders a 3D object that changes color when " +
            "one of the virtual buttons is triggered.\n" +
            "\n" +
            keyFunctionality + "\n" +
            "• Button occlusion event handling\n" +
            "\n" +
            targets + "\n" +
            "• Included Targets\n" +
            "\n" +
            instructions + "\n" +
            "• Point camera at target to view\n" +
            "• Single tap to focus\n" +
            "\n" +
            footer + "\n");

    }

    #endregion // CONSTRUCTOR

}
