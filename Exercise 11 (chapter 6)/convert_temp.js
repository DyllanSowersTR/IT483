"use strict";
var $ = function(id) { return document.getElementById(id); };


var clearTextBoxes = function() {
    $("degrees_entered").value = "";
    $("degrees_computed").value = "";
};

var toFahrenheit = function() {
    $("degree_label_1").innerHTML = 'Enter C degrees:';
    $("degree_label_2").innerHTML = 'Degrees Fahrenheit:';
    clearTextBoxes();
    $("degrees_entered").focus();
};

var toCelsius = function() {
    $("degree_label_1").innerHTML = 'Enter F degrees:';
    $("degree_label_2").innerHTML = 'Degrees Celsius:';
    clearTextBoxes();
    $("degrees_entered").focus();
};

var convertTemp = function () {
    if(isNaN($("degrees_entered").value) || ($("degrees_entered").value) == ''){
        alert('You must enter a valid number for degrees.');
    }
    else if ( $("to_celsius").checked ) {
        $("degrees_computed").value =
            (($("degrees_entered").value - 32) * (5/9)).toFixed(0);
    }
    else if ( $("to_fahrenheit").checked ) {
        $("degrees_computed").value =
            (($("degrees_entered").value * (5/9) + 32)).toFixed(0);
    };
    $("degrees_entered").focus();
            
    
};

window.onload = function() {
    $("convert").onclick = convertTemp;
    $("to_celsius").onclick = toCelsius;
    $("to_fahrenheit").onclick = toFahrenheit;
	$("degrees_entered").focus();
};