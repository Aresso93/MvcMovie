// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function validateString() {
    let myString = document.getElementById("price-form").value
    if (myString.trim().includes('.')) {
        myParsedString = myString.replace('.', ',')
        document.getElementById("price-form").value = myParsedString
    } 
} 
