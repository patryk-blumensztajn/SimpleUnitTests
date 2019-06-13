document.addEventListener("DOMContentLoaded", function () {
    var element = document.createElement("p");
    element.textContent = "To jest element ze zmodyfikowanego third";
    document.querySelector("body").appendChild(element);
})