using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
 public class Tutorial
 {
  protected int TutorialID; 
  protected string TutorialName;
  
  public void SetTutorial(int pID,string pName) 
  {
   TutorialID=pID;
   TutorialName=pName;
  }
  
  public String GetTutorial()
  {
   return TutorialName;
  }
 }
  public class Guru99Tutorial:Tutorial
  {
   public void RenameTutorial(String pNewName)
   {
    TutorialName=pNewName;
   }
  
  static void Main(string[] args) 
  {
   Guru99Tutorial pTutor=new Guru99Tutorial();
   
   pTutor.RenameTutorial(".Net by Guru99");
    
   Console.WriteLine(pTutor.GetTutorial());
    
   Console.ReadKey(); 
  }
 }
}