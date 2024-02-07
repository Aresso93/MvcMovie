// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function validateString() {
    let val = 2;
    let myString = document.getElementById("price-form").value
    if (myString.includes('.')) {
        myString = myString.replace('.', ',');
        myString = myString.slice(0, (myString.indexOf(",")) + val + 1);
        document.getElementById("price-form").value = myString

    } else if (myString.includes(',')) {
        myString = myString.slice(0, (myString.indexOf(",")) + val + 1);
        document.getElementById("price-form").value = myString
    }
} 

function validateEditString() {
    let val = 2;
    let myString = document.getElementById("edit-price-form").value
    if (myString.includes('.')) {
        myString = myString.replace('.', ',');
        myString = myString.slice(0, (myString.indexOf(",")) + val + 1);
        document.getElementById("edit-price-form").value = myString

    } else if (myString.includes(',')) {
        myString = myString.slice(0, (myString.indexOf(",")) + val + 1);
        document.getElementById("edit-price-form").value = myString
    }
} 

//Window.onload = function () {
//    let today = new Date();
//    let dd = today.getDate();
//    let mm = today.getMonth() + 1;
//    let yyyy = today.getFullYear() + 1;
//    console.log(yyyy);

//    if (dd < 10) {
//        dd = '0' + dd;
//    }

//    if (mm < 10) {
//        mm = '0' + mm;
//    }

//    today = dd + '-' + mm + '-' + yyyy;
//    document.getElementById("date-form").value = today
//}

function defaultDate() {
    let today = new Date();
    let dd = today.getDate();
    let mm = today.getMonth() + 1;
    let yyyy = today.getFullYear() + 1;

    if (dd < 10) {
        dd = '0' + dd;
    }

    if (mm < 10) {
        mm = '0' + mm;
    }

    today = dd + '-' + mm + '-' + yyyy;
    document.getElementById("date-form").value = today
}

function nextYearDate() {
    let yourDate = new Date()
    yourDate.toISOString().split('T')[0]
    console.log(yourDate.toISOString().split('T')[0])
}

function getDate() {
    let today = new Date();
    let dd = today.getDate();
    let mm = today.getMonth() + 1;
    let yyyy = today.getFullYear() +1;

    if (dd < 10) {
        dd = '0' + dd;
    }

    if (mm < 10) {
        mm = '0' + mm;
    }

    today = dd + '-' + mm + '-' + yyyy;
    console.log(today.trim());
    return today.trim();
}

function test() {
    console.log("2021-10-20")
    return "2021-10-20"
}