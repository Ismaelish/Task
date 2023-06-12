// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function openNav() {
    document.getElementById("mySidenav").style.width = "250px";
    document.getElementById("main01").style.marginLeft = "250px";
    document.getElementById("main02").style.marginLeft = "250px";
    document.getElementById("mytopnav").style.marginLeft = "250px";

}
function closeNav() {
    document.getElementById("mySidenav").style.width = "0";
    document.getElementById("main01").style.marginLeft = "0";
    document.getElementById("main02").style.marginLeft = "0";
    document.getElementById("mytopnav").style.marginLeft = "0";
}