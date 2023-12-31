//-----------------------------------------------------------------------
// <copyright file="ObjectController.cs" company="Google LLC">
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------

using System.Collections;
using UnityEngine;

/// <summary>
/// Controls target objects behaviour.
/// </summary>
public class ObjectController : MonoBehaviour
{
    public GameObject EnterObject;
    public GameObject Treasure;
    public GameObject goodAnswer;
    public GameObject badAnswer;
    
    

    

    /// <summary>
    /// Teleports this instance randomly when triggered by a pointer click.
    /// </summary>
    

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>

    public void OnPointerEnterXR()
    {

        EnterObject.SetActive(false);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExitXR()
    {
        EnterObject.SetActive(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClickXR()
    {
        if(gameObject.tag == "objective"){
            Treasure.SetActive(false);
            goodAnswer.SetActive(true);
            gameObject.tag = "noTag";
            ControllerData.numberArrows++;
            ControlAlarm.isAlarm = true;
        }
        else {
            Treasure.SetActive(false);
            badAnswer.SetActive(true);
            gameObject.tag = "noTag";
            ControllerData.numberArrows--;
            ControlAlarm.isAlarm = true;
        }

    }

    /// <summary>
    /// Sets this instance's material according to gazedAt status.
    /// </summary>
    ///
    
    
}
