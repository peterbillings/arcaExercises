using System;

 namespace tictactoeApi 
 {
     public class GameUpdateResponse 
     {
         public string ChosenSquare {get; set;}

         public string Winner {get; set;}

         public string Turn {get; set;}
     }
 }