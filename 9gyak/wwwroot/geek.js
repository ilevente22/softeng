﻿var viccek;
function letöltés() {
    fetch('/jokes.json')
        .then(response => response.json())
        .then(data => letöltésBefejeződött(data)
        );
}

function letöltésBefejeződött(d) {
    console.log("Sikeres letöltés")
    console.log(d)
    viccek = d;

    for (var i = 0; i < viccek.length; i++) {
        viccf = JSON.parse(viccek)
        var viccf = new Array()
    }
}
window.onload(letöltés());