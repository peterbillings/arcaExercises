// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

var ajaxButton = document.getElementById("ajaxbutton");

ajaxButton.addEventListener("click", helloWorld);

function helloWorld() {
    var xhr = new XMLHttpRequest();

    xhr.open('GET', 'https://localhost:5003/api/values/stealidentity?firstName=Peter&lastName=Billings');

    xhr.onload = function() {
        var target = document.getElementById('injectionTarget');

        target.innerHTML = this.response;
    }

    xhr.send();
}

var gameBoard = document.getElementById("gameboard");

var square9 = document.getElementById("9");
var square8 = document.getElementById("8");
var square7 = document.getElementById("7");
var square6 = document.getElementById("6");
var square5 = document.getElementById("5");
var square4 = document.getElementById("4");
var square3 = document.getElementById("3");
var square2 = document.getElementById("2");
var square1 = document.getElementById("1");

var reset = document.getElementById("reset");

var xTurn = document.getElementById("xturn");
var oTurn = document.getElementById("oturn");
var xWins = document.getElementById("xwins");
var oWins = document.getElementById("owins");
var draw = document.getElementById("draw");

square9.addEventListener("click", makeAMove);
square8.addEventListener("click", makeAMove);
square7.addEventListener("click", makeAMove);
square6.addEventListener("click", makeAMove);
square5.addEventListener("click", makeAMove);
square4.addEventListener("click", makeAMove);
square3.addEventListener("click", makeAMove);
square2.addEventListener("click", makeAMove);
square1.addEventListener("click", makeAMove);

reset.addEventListener("click", resetBoard);


function makeAMove() {

    var isWinner = xWins.style.display === "block" ||
                   oWins.style.display === "block";

    if (this.innerHTML === '' && !isWinner) {

        var xhr = new XMLHttpRequest();

        xhr.open('POST', 'https://localhost:5003/api/values');

        xhr.setRequestHeader("Content-Type", "application/JSON");

        var tictactoeBoardState = {
            "chosenSquare": this.id,
            "_9": square9.innerHTML,
            "_8": square8.innerHTML,
            "_7": square7.innerHTML,
            "_6": square6.innerHTML,
            "_5": square5.innerHTML,
            "_4": square4.innerHTML,
            "_3": square3.innerHTML,
            "_2": square2.innerHTML,
            "_1": square1.innerHTML,
        };

        var boardStateJSON = JSON.stringify(tictactoeBoardState);

        xhr.onload = function() {

            console.log(this.response);

            var response = JSON.parse(this.response);

            var chosenSquare = document.getElementById(response.chosenSquare);

            chosenSquare.innerHTML = response.turn;

            if(response.turn === "X") {
                xTurn.style.display = "none";
                oTurn.style.display = "block";
            }

            if(response.turn === "O") {
                oTurn.style.display = "none";
                xTurn.style.display = "block";
            }

            if(response.winner === "X") {
                oTurn.style.display = "none";
                xTurn.style.display = "none";
                xWins.style.display = "block";
            }

            if(response.winner === "O") {
                xTurn.style.display = "none";
                oTurn.style.display = "none";
                oWins.style.display = "block";
            }

            if(response.winner === "Draw") {
                xTurn.style.display = "none";
                oTurn.style.display = "none";
                draw.style.display = "block";
            }

            //console.log(response.chosenSquare);
            //console.log(response.turn);

        }

        xhr.send(boardStateJSON);
    }
}

function resetBoard() {
    var boardState = gameBoard.getElementsByTagName('li');

    for (i = 0; i < 9; i++) {
		boardState[i].innerHTML = "";
	}
	
	xWins.style.display = "none";
	oWins.style.display = "none";
	draw.style.display = "none";
	xTurn.style.display = "block";
	oTurn.style.display = "none";
}
