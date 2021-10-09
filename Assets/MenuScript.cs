using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;
using Debug = UnityEngine.Debug;

public class MenuScript : MonoBehaviour
{
   public void Save()
   {
      Debug.Log("Save");
      
      
      
      PlayerPrefs.Save();
   }

   public void Load()
   {
      Debug.Log("Load");
      

   }

   public void Exit()

   {
      Debug.Log("Exit");

   }
}
