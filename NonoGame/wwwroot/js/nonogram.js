var sec = 0;
var min = 0;
var timeGame = null;

var board;
var random;
var imageSelected;
var img = array;
var arraySelected;

var isOn = false;

$(document).ready(function () {
	$("#start").click(function () {
		if (!isOn) {
			isOn = true;
			$("#top").empty();
			$("#first").empty();
			$("#second").empty();
			start();
		}
		else return;
	});
});

function clearBoard() {
	isOn = false;

	min = 0;
	sec = 0;

	board = null;
	clearInterval(timeGame);
	timeGame = null;
}

function time() {
	if (isOn) {
		if (sec <= 9 && min <= 9)
			$('#time').html('0' + min + ":" + '0' + sec++);
		else if (sec <= 9 && min > 9)
			$('#time').html(min + ":" + '0' + sec++);
		else if (sec > 9 && sec < 59 && min <= 9)
			$('#time').html('0' + min + ":" + sec++);
		else if (sec > 9 && sec < 59 && min > 9)
			$('#time').html(min + ":" + sec++);
		else if (sec == 59 && min <= 9) {
			$('#time').html('0' + min + ":" + sec);
			min++;
			sec = 0;
		}
		else if (sec == 59 && min > 9) {
			$('#time').html(min + ":" + sec);
			min++;
			sec = 0;
		}
	}
}

function start() {
	$('#win').hide();
	board = new GameBoard(size, size);
	timeGame = setInterval(time, 1000);
}

function GameBoard(n, m) {
	this.n = n;
	this.m = m;

	arraySelected = Array(size).fill().map(() => Array(size).fill(0));

	$("#top").append("<table id=tableHorizontal>");
	for (var i = 1; i >= 0; i--) {
		$("#tableHorizontal").append("<tr id=row" + i + ">");
		for (var j = 0; j < m; j++) {
			$("#tableHorizontal #row" + i).append("<td id=h" + i + "_" + j + "></td>");
		}
		$("#tableHorizontal").append("</tr>");
	}

	$("#first").append("<table id=tableVertical>");
	for (var i = 0; i < n; i++) {
		$("#tableVertical").append("<tr id=row" + i + ">");
		for (var j = 1; j >= 0; j--) {
			$("#tableVertical #row" + i).append("<td id=v" + i + "_" + j + "></td>");
		}
		$("#tableVertical").append("</tr>");
	}

	$("#second").append("<table id=tableCenter>");
	for (var i = 0; i < n; i++) {
		$("#tableCenter").append("<tr id=row" + i + ">");
		for (var j = 0; j < m; j++) {
			$("#tableCenter #row" + i).append("<td id=" + i + "_" + j + "></td>");
			$("#" + i + "_" + j).bind("click", function () {
				black(this);
			});
			$("#" + i + "_" + j).bind("contextmenu", function (event) {
				event.preventDefault();
				blue(this);
			});
		}
		$("#tableCenter").append("</tr>");
	}

	$("#time").html('0' + min + ":" + '0' + sec++);
	$("#clock").fadeIn(500).css("display","flex");
	$("#board").fadeIn(500);

	function blue(obj) {
		if (isOn) {
			var id = obj.id;

			if ($('#' + id).hasClass('')) {
				$('#' + id).addClass('blue');
			}
			else if ($('#' + id).hasClass('blue')) {
				$('#' + id).removeClass();
			}
		}
	}

	function black(obj) {
		if (isOn) {
			var id = obj.id;
			var values = id.split("_");
			var row = values[0];
			var column = values[1];

			if ($('#' + id).hasClass('')) {
				$('#' + id).addClass('black');
				arraySelected[row][column] = 1;
			}
			else if ($('#' + id).hasClass('black')) {
				$('#' + id).removeClass();
				arraySelected[row][column] = 0;
			}

			if (checkIfFilled() == true) {
				$('#win').css("display", "flex");
				clearBoard();
			}
		}
	}

	function checkIfFilled() {
		for (var i = 0; i < size; i++) {
			for (var j = 0; j < size; j++) {
				if (arraySelected[i][j] != array[i][j]) {
					return false;
				}
			}
		}
		return true;
	}

	function create(imageSelected) {
		var black = 0;
		var tempV = 0;
		var tempH = 0;
		var groundV = 1;
		var groundH = 1;

		for (var r = 0; r < imageSelected.length; r++) {
			for (var c = imageSelected[r].length - 1; c >= 0; c--) {
				if (imageSelected[r][c] == 1) {
					black++;
				}
				else if (imageSelected[r][c] == 0 && black != 0) {
					if (tempV > groundV) {
						for (var i = 0; i < n; i++) {
							$("#tableVertical #row" + i).prepend("<td id=v" + i + "_" + tempV + "></td>");
						}
						groundV++;
					}
					$('#v' + r + "_" + tempV).html(black);
					tempV++;
					black = 0;
				}
			}
			if (black != 0) {
				$('#v' + r + "_" + tempV).html(black);
				black = 0;
			}
			tempV = 0;
		}

		var c = 0;
		var rImg = imageSelected.length - 1;
		while (c < imageSelected[rImg].length) {
			for (var r = imageSelected.length - 1; r >= 0; r--) {
				if (imageSelected[r][c] == 1) {
					black++;
				}
				else if (imageSelected[r][c] == 0 && black != 0) {
					$('#h' + tempH + "_" + c).html(black);
					tempH++;
					black = 0;
					if (tempH > groundH) {
						$("#tableHorizontal").prepend("<tr id=row" + tempH + ">");
						for (var i = 0; i < m; i++) {
							$("#tableHorizontal #row" + tempH).append("<td id=h" + tempH + "_" + i + "></td>");
						}
						$("#tableHorizontal").append("</tr>");
						groundH++;
					}
				}
			}
			if (black != 0) {
				$('#h' + tempH + "_" + c).html(black);
				black = 0;
			}
			tempH = 0;
			c++;
		}
	}

	create(array);
}