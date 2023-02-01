// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function newColor() {
    document.getElementById("hello_world").style.color = "blue";
}

function oldColor() {
    document.getElementById("hello_world").style.color = "green";
}

// Wrap every letter in a span
var textWrapper = document.querySelector('.display-4');
textWrapper.innerHTML = textWrapper.textContent.replace(/\S/g, "<span class='letter'>$&</span>");

anime.timeline({ loop: true })
    .add({
        targets: '.display-4 .letter',
        scale: [4, 1],
        opacity: [0, 1],
        translateZ: 0,
        easing: "easeOutExpo",
        duration: 950,
        delay: (el, i) => 70 * i
    }).add({
        targets: '.display-4',
        opacity: 0,
        duration: 1000,
        easing: "easeOutExpo",
        delay: 1000
    });