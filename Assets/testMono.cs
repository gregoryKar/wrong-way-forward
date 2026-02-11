using kar_main_utils;
using karianakisEditTools;
using UnityEngine;

public class testMono : MonoBehaviour
{
  void Start()
    {
        invo.simple(action:()=>{Debug.Log("WORKS");}, delay: 2f);
        EditTerminal.AddCommand("greg", testing);
        EditTerminal.AddCommand("malt", ()=>{Debug.Log("WOooooooooooRKS");});
        ShortcutAction.Create("testing", ()=>{Debug.Log("WORKS");},KeyCode.K);
    }
 // just a test mono to comit 

  void testing()
    {
      Debug.Log("wooooooooooooooooooooooooooork");
    }

}
