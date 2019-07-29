using System;

namespace tictactoeApi {

    public class TictactoeBoard {

        public string ChosenSquare {get; set;}
        
        public string _9 {get; set;}
 
        public string _8 {get; set;}

        public string _7 {get; set;}

        public string _6 {get; set;}

        public string _5 {get; set;}

        public string _4 {get; set;}

        public string _3 {get; set;}

        public string _2 {get; set;}

        public string _1 {get; set;}

        public string extraData {get; set;} // this member is useless, I just added it to see whether
                                            // the server side request data structure had to match
                                            // the client side exactly, but it does not seem to be the case;
                                            // it seems as though, there just needs to be a matching instance
                                            // variable on the server side to bind to any variable in the JSON
                                            // request.
    }
    
}