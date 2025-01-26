// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//DarkMode-metod
document.addEventListener("DOMContentLoaded", () => {

    //Hämtar ID
    const toggleButton = document.getElementById("darkModeToggle");

    //Sätter eventlyssnare
    toggleButton.addEventListener("click", () => {

        //Togglar till darkMode
        document.body.classList.toggle("dark-mode");
    });
});