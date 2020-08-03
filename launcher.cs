using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PlayToontownRemodified
{
   class Launcher
  {   
   
   public void PlayGame()
   {
      Process.Start("game.exe")
   }
      
      public void LaunchWebsite(string url) 
   {
    
       Process.Start(url);
          }
     }
}
